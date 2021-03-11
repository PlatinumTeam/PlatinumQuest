//-----------------------------------------------------------------------------
// Copyright (c) 2021 The Platinum Team
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
//-----------------------------------------------------------------------------

if (!isObject(ActiveTexturePacks)) {
	RootGroup.add(Array("ActiveTexturePacks"));
}

$TexturePack::ValidField["bitmapColor"] = true;
$TexturePack::ValidField["border"] = true;
$TexturePack::ValidField["borderColor"] = true;
$TexturePack::ValidField["borderColorHL"] = true;
$TexturePack::ValidField["borderColorNA"] = true;
$TexturePack::ValidField["cursorColor"] = true;
$TexturePack::ValidField["fillColor"] = true;
$TexturePack::ValidField["fillColorHL"] = true;
$TexturePack::ValidField["fillColorNA"] = true;
$TexturePack::ValidField["fontColor"] = true;
$TexturePack::ValidField["fontColorHL"] = true;
$TexturePack::ValidField["fontColorNA"] = true;
$TexturePack::ValidField["fontColorSEL"] = true;
$TexturePack::ValidField["fontColors[0]"] = true;
$TexturePack::ValidField["fontColors[1]"] = true;
$TexturePack::ValidField["fontColors[2]"] = true;
$TexturePack::ValidField["fontColors[3]"] = true;
$TexturePack::ValidField["fontColors[4]"] = true;
$TexturePack::ValidField["fontColors[5]"] = true;
$TexturePack::ValidField["fontColors[5]"] = true;
$TexturePack::ValidField["fontColors[6]"] = true;
$TexturePack::ValidField["fontColors[7]"] = true;
$TexturePack::ValidField["fontColors[8]"] = true;
$TexturePack::ValidField["fontColors[9]"] = true;
$TexturePack::ValidField["fontColorLink"] = true;
$TexturePack::ValidField["fontColorLinkHL"] = true;

function activateTexturePack(%packName) {
	//If we're already loaded, unload first
	for (%i = 0; %i < ActiveTexturePacks.getSize(); %i ++) {
		%pack = ActiveTexturePacks.getEntry(%i);
		if (%pack.identifier $= %packname) {
			unloadTexturePack(%pack);
			ActiveTexturePacks.removeEntry(%i);
			%i --;
		}
	}

	%packBase = $usermods @ "/data/texture_packs/" @ %packName;
	%packFile = %packBase @ "/pack.json";
	%pack = jsonParse(fread(%packfile));
	%pack.identifier = %packName;
	%pack.base = %packBase;

	PlayGui.updateGems();

	warn("Loading texture pack: " @ %pack.name);
	ActiveTexturePacks.addEntry(%pack);
}

function deactivateTexturePack(%packName) {
	//Unload this pack
	for (%i = 0; %i < ActiveTexturePacks.getSize(); %i ++) {
		%pack = ActiveTexturePacks.getEntry(%i);
		if (%pack.identifier $= %packname) {
			unloadTexturePack(%pack);
			ActiveTexturePacks.removeEntry(%i);
			%i --;
		}
	}
}

function reloadTexturePacks() {
	//Unload everything first
	for (%i = 0; %i < ActiveTexturePacks.getSize(); %i ++) {
		%pack = ActiveTexturePacks.getEntry(%i);
		unloadTexturePack(%pack);
	}
	//Then load everything back
	for (%i = 0; %i < ActiveTexturePacks.getSize(); %i ++) {
		%pack = ActiveTexturePacks.getEntry(%i);
		loadTexturePack(%pack);
	}
	reloadShaders();
	reloadPostFX();
	clearTextureHolds();
	purgeResources();
	flushTextureCache();
}

//Faster version of reloadTexturePacks that doesn't do any of the bitmap swapping or
// slower flushing of textures
function reloadTexturePackFields() {
	for (%i = 0; %i < ActiveTexturePacks.getSize(); %i ++) {
		%pack = ActiveTexturePacks.getEntry(%i);
		loadTexturePackFields(%pack);
	}
}

function unloadTexturePacks() {
	for (%i = 0; %i < ActiveTexturePacks.getSize(); %i ++) {
		%pack = ActiveTexturePacks.getEntry(%i);
		unloadTexturePack(%pack);
	}
	ActiveTexturePacks.clear();
	reloadShaders();
	reloadPostFX();
	clearTextureHolds();
	purgeResources();
	flushTextureCache();
}

function loadTexturePack(%pack) {
	if (isObject(%pack.shaders)) {
		%fields = %pack.shaders.getDynamicFieldList();
		%count = getFieldCount(%fields);
		for (%i = 0; %i < %count; %i ++) {
			%field = getField(%fields, %i);
			%value = %pack.shaders.getFieldValue(%field);
			if (!isObject(%value)) {
				continue;
			}
			%vertex = texturePackResolveFile(%pack, %value.vertex);
			%fragment = texturePackResolveFile(%pack, %value.fragment);

			devecho("Register shader: " @ %field @ " with vertex " @ %vertex @ " and fragment " @ %fragment);
			registerShader(%field, %vertex, %fragment);
		}
	}
	if (isObject(%pack.postfx)) {
		$TexturePack::PostFX::ShaderV = texturePackResolveFile(%pack, %pack.postfx.shaderV);
		$TexturePack::PostFX::ShaderF = texturePackResolveFile(%pack, %pack.postfx.shaderF);
	}
	if (isObject(%pack.materials)) {
		%fields = %pack.materials.getDynamicFieldList();
		%count = getFieldCount(%fields);
		for (%i = 0; %i < %count; %i ++) {
			%field = getField(%fields, %i);
			%value = %pack.materials.getFieldValue(%field);
			if (!isObject(%value)) {
				continue;
			}

			devecho("Register material: " @ %field);

			%value.setName(%field);
			MaterialGroup.add(%value);
		}
	}
	if (isObject(%pack.texture_materials)) {
		%fields = %pack.texture_materials.getDynamicFieldList();
		%count = getFieldCount(%fields);
		for (%i = 0; %i < %count; %i ++) {
			%field = getField(%fields, %i);
			%value = %pack.texture_materials.getFieldValue(%field);
			%real = texturePackResolveFile(%pack, %value);

			devecho("Register material: " @ %field @ " with " @ %real);
			registerMaterial(%field, %real);
		}
	}
	if (isObject(%pack.material_replacements)) {
		%fields = %pack.material_replacements.getDynamicFieldList();
		%count = getFieldCount(%fields);
		for (%i = 0; %i < %count; %i ++) {
			%field = getField(%fields, %i);
			%value = %pack.material_replacements.getFieldValue(%field);
			%real = texturePackResolveFile(%pack, %value);

			devecho("Replace material: " @ %field @ " with " @ %real);
			replaceMaterials(%field, %real);
		}
	}
	if (isObject(%pack.bitmap_swaps)) {
		%fields = %pack.bitmap_swaps.getDynamicFieldList();
		%count = getFieldCount(%fields);
		for (%i = 0; %i < %count; %i ++) {
			%field = getField(%fields, %i);
			%value = %pack.bitmap_swaps.getFieldValue(%field);
			%real = texturePackResolveFile(%pack, %value);

			devecho("Swap texture: " @ %field @ " with " @ %real);

			// What the fuck are transparency why do they not fucking revert
			if (strpos(%field, "platinum/client/ui/lb/core/transparency/") == -1) {
				swapTextures(%field, %real);
			} else {
				// Just set a variable and die inside
				$TexturePack::SwapTextures[%field] = %real;
			}
		}
	}
	loadTexturePackFields(%pack);
}

function loadTexturePackFields(%pack) {
	if (isObject(%pack.timer_color)) {
		$TimeColor["normal"] = %pack.timer_color.normal;
		$TimeColor["danger"] = %pack.timer_color.danger;
		$TimeColor["stopped"] = %pack.timer_color.stopped;
	}
	if (isObject(%pack.color_swaps)) {
		%objects = %pack.color_swaps.getDynamicFieldList();
		%count = getFieldCount(%objects);
		for (%i = 0; %i < %count; %i ++) {
			%object = getField(%objects, %i);
			%colorList = %pack.color_swaps.getFieldValue(%object);

			if (isObject(%object)) {
				%colors = %colorList.getDynamicFieldList();
				%colCount = getFieldCount(%colors);
				for (%j = 0; %j < %colCount; %j ++) {
					%field = getField(%colors, %j);
					%color = %colorList.getFieldValue(%field);

					if (!$TexturePack::ValidField[%field]) {
						continue;
					}

					devecho("Swap " @ %field @ " for " @ %object @ " with " @ %color);
					texturePackFieldSwap(%object, %field, %color);
				}
			}
		}
	}
	if (%pack.invert_text_colors !$= "") {
		$TexturePack::InvertTextColors = %pack.invert_text_colors;
	}
	//Find all the GuiMLTextCtrls and update their text
	texturePackRecurse(GuiGroup);
}

function unloadTexturePack(%pack) {
	if (isObject(%pack.bitmap_swaps)) {
		%fields = %pack.bitmap_swaps.getDynamicFieldList();
		%count = getFieldCount(%fields);

		for (%i = 0; %i < %count; %i ++) {
			%field = getField(%fields, %i);
			//Unload that texture
			devecho("Unswap texture: " @ %field);
			swapTextures(%field);
			$TexturePack::SwapTextures[%field] = "";
		}
	}
	if (isObject(%pack.postfx)) {
		$TexturePack::PostFX::ShaderV = "";
		$TexturePack::PostFX::ShaderF = "";
	}
	if (isObject(%pack.material_replacements)) {
		%fields = %pack.material_replacements.getDynamicFieldList();
		%count = getFieldCount(%fields);
		for (%i = 0; %i < %count; %i ++) {
			%field = getField(%fields, %i);

			devecho("Unreplace material: " @ %field);
			replaceMaterials(%field);
		}
	}
	if (isObject(%pack.color_swaps)) {
		%objects = %pack.color_swaps.getDynamicFieldList();
		%count = getFieldCount(%objects);
		for (%i = 0; %i < %count; %i ++) {
			%object = getField(%objects, %i);
			%colorList = %pack.color_swaps.getFieldValue(%object);

			if (isObject(%object)) {
				%colors = %colorList.getDynamicFieldList();
				%colCount = getFieldCount(%colors);
				for (%j = 0; %j < %colCount; %j ++) {
					%field = getField(%colors, %j);

					if (!$TexturePack::ValidField[%field]) {
						continue;
					}

					devecho("Restore " @ %field @ " for " @ %object);
					texturePackFieldRestore(%object, %field);
				}
			}
		}
	}
}

function texturePackResolveFile(%pack, %file) {
	%file = strreplace(%file, "./", %pack.base @ "/");
	%file = expandFilename(%file);

	return %file;
}

function texturePackFieldSwap(%obj, %field, %new) {
	if (%obj.__old[%field] $= "") {
		%obj.__old[%field] = %obj.getFieldValue(%field);
	}
	%obj.setFieldValue(%field, %new);
}

function texturePackFieldRestore(%obj, %field) {
	if (%obj.__old[%field] !$= "") {
		%obj.setFieldValue(%field, %obj.__old[%field]);
	}
}

function texturePackRecurse(%group) {
	%count = %group.getCount();
	for (%i = 0; %i < %count; %i ++) {
		%obj = %group.getObject(%i);
		%class = %obj.getClassName();

		if (%class $= "GuiMLTextCtrl" && %obj.unformattedText !$= "") {
			%obj.setText(%obj.unformattedText);
		}
		if (%obj.hasTransparency) {
			%obj.reloadTransparency();
		}

		texturePackRecurse(%obj);
	}
}
