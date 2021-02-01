//-----------------------------------------------------------------------------
// opCodes.cs
//
// Copyright (c) 2013 The Platinum Team
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

// OP codes replace keywords with number offsets, to help reduce file size
// during transmission from server->client.
// There's nothing else to this really. Just make sure the OP codes for
// numerical match up with the strings

$OP::Key["SimGroup"]         = "`a0";
$OP::Key["Sun"]              = "`a1";
$OP::Key["Sky"]              = "`a2";
$OP::Key["InteriorInstance"] = "`a3";
$OP::Key["StaticShape"]      = "`a4";
$OP::Key["TSStatic"]         = "`a5";
$OP::Key["Item"]             = "`a6";
$OP::Key["Trigger"]          = "`a7";
$OP::Key["ScriptObject"]     = "`a8";
$OP::Key["MissionArea"]      = "`a9";
$OP::Key["AudioProfile"]     = "`b0";

$OP::Key["`a0"] = "SimGroup";
$OP::Key["`a1"] = "Sun";
$OP::Key["`a2"] = "Sky";
$OP::Key["`a3"] = "InteriorInstance";
$OP::Key["`a4"] = "StaticShape";
$OP::Key["`a5"] = "TSStatic";
$OP::Key["`a6"] = "Item";
$OP::Key["`a7"] = "Trigger";
$OP::Key["`a8"] = "ScriptObject";
$OP::Key["`a9"] = "MissionArea";
$OP::Key["`b0"] = "AudioProfile";

//-----------------------------------------------------------------------------

$OP::Key["dataBlock"]                    = "`c0";
$OP::Key["position"]                     = "`c1";
$OP::Key["rotation"]                     = "`c2";
$OP::Key["scale"]                        = "`c3";
$OP::Key["interiorFile"]                 = "`c4";
$OP::Key["polyhedron"]                   = "`c5";
$OP::Key["showTerrainInside"]            = "`c6";
$OP::Key["collideable"]                  = "`c7";
$OP::Key["static"]                       = "`c8";
$OP::Key["rotate"]                       = "`c9";
$OP::Key["GemItemRed"]                   = "`d0";
$OP::Key["GemItemYellow"]                = "`d1";
$OP::Key["GemItemBlue"]                  = "`d2";
$OP::Key["SpawnTrigger"]                 = "`d3";
$OP::Key["0.0000000 0.0000000 0.0000000 1.0000000 0.0000000 0.0000000 0.0000000 -1.0000000 0.0000000 0.0000000 0.0000000 1.0000000"] = "`d4";
$OP::Key["1 1 1"]                        = "`d5";
$OP::Key["1 0 0 0"]                      = "`d6";
$OP::Key["0 0 1"]                        = "`d7";
$OP::Key["HelicopterItem"]               = "`d8";
$OP::Key["DuctFan"]                      = "`d9";
$OP::Key["SuperSpeedItem"]               = "`e0";
$OP::Key["SuperJumpItem"]                = "`e1";
$OP::Key["MegaMarbleItem"]               = "`e2";
$OP::Key["BlastItem"]                    = "`e3";
$OP::Key["/data/multiplayer/interiors"]  = "`e4";
$OP::Key[".dif"]                         = "`e5";
$OP::Key[".dts"]                         = "`e6";
$OP::Key["//--- OBJECT WRITE BEGIN ---"] = "`e7";
$OP::Key["//--- OBJECT WRITE END ---"]   = "`e8";
$OP::Key["RandomPowerUpItem"]            = "`f0";
$OP::Key["FireBallItem"]                 = "`f1";
$OP::Key["CustomSuperJumpItem_PQ"]       = "`f2";
$OP::Key["AntiGravityItem_PQ"]           = "`f3";
$OP::Key["SuperJumpItem_PQ"]             = "`f4";
$OP::Key["SuperBounceItem_PQ"]           = "`f5";
$OP::Key["SuperSpeedItem_PQ"]            = "`f6";
$OP::Key["ShockAbsorberItem_PQ"]         = "`f7";
$OP::Key["HelicopterItem_PQ"]            = "`f8";
$OP::Key["TimeTravelItem_PQ"]            = "`f9";
$OP::Key["RespawningTimeTravelItem"]     = "`l0";
$OP::Key["RespawningTimePenaltyItem"]    = "`l1";
$OP::Key["RespawningTimeTravelItem_PQ"]  = "`l2";
$OP::Key["RespawningTimePenaltyItem_PQ"] = "`l3";
$OP::Key["easterEgg"]                    = "`l4";
$OP::Key["GemItem"]                      = "`l5";
$OP::Key["GemItemPurple"]                = "`l6";
$OP::Key["GemItemGreen"]                 = "`l7";
$OP::Key["GemItemTurquoise"]             = "`l8";
$OP::Key["GemItemOrange"]                = "`l9";
$OP::Key["GemItemBlack"]                 = "`m0";
$OP::Key["GemItemPlatinum"]              = "`m1";
$OP::Key["GemItem_PQ"]                   = "`m2";
$OP::Key["GemItemBlue_PQ"]               = "`m3";
$OP::Key["GemItemRed_PQ"]                = "`m4";
$OP::Key["GemItemYellow_PQ"]             = "`m5";
$OP::Key["GemItemPurple_PQ"]             = "`m6";
$OP::Key["GemItemGreen_PQ"]              = "`m7";
$OP::Key["GemItemTurquoise_PQ"]          = "`m8";
$OP::Key["GemItemOrange_PQ"]             = "`m9";
$OP::Key["GemItemBlack_PQ"]              = "`n0";
$OP::Key["GemItemPlatinum_PQ"]           = "`n1";
$OP::Key["FancyGemItem_PQ"]              = "`n2";
$OP::Key["NestEgg_PQ"]                   = "`n3";
$OP::Key["NoRespawnAntiGravityItem"]     = "`n4";
$OP::Key["NoRespawnAntiGravityItem_PQ"]  = "`n5";
$OP::Key["TeleportItem"]                 = "`n6";
$OP::Key["AnvilItem"]                    = "`n7";
$OP::Key["BubbleItem"]                   = "`n8";
$OP::Key["FadePlatform"]                 = "`n9";
$OP::Key["FadePlatform2_1x1"]            = "`o0";
$OP::Key["FadePlatform2_1x2"]            = "`o1";
$OP::Key["FadePlatform2_1x3"]            = "`o2";
$OP::Key["FadePlatform2_1x5"]            = "`o3";
$OP::Key["FadePlatform2_2x2"]            = "`o4";
$OP::Key["FadePlatform2_3x3"]            = "`o5";
$OP::Key["FadePlatform2_5x5"]            = "`o6";
$OP::Key["FadePlatformConcrete"]         = "`o7";
$OP::Key["FadePlatformGrass"]            = "`o8";
$OP::Key["FadePlatformIce"]              = "`o9";
$OP::Key["target"]                       = "`p0";
$OP::Key["DefaultCannon"]                = "`p1";
$OP::Key["Cannon_Low"]                   = "`p2";
$OP::Key["Cannon_Mid"]                   = "`p3";
$OP::Key["Cannon_High"]                  = "`p4";
$OP::Key["Cannon_Custom"]                = "`p5";
$OP::Key["DefaultCannonBase"]            = "`p6";
$OP::Key["HelpBubble"]                   = "`p7";
$OP::Key["Fence_1TilesLength"]           = "`p8";
$OP::Key["Fence_2TilesLength"]           = "`p9";
$OP::Key["Fence_3TilesLength"]           = "`q0";
$OP::Key["Fence_4TilesLength"]           = "`q1";
$OP::Key["Fence_5TilesLength"]           = "`q2";
$OP::Key["FencePole"]                    = "`q3";
$OP::Key["Plant01"]                      = "`q4";
$OP::Key["Fern01"]                       = "`q5";
$OP::Key["Floweres"]                     = "`q6";
$OP::Key["Tulip"]                        = "`q7";
$OP::Key["Scarce_Tulips"]                = "`q8";
$OP::Key["Dense_Tulips"]                 = "`q9";
$OP::Key["grass"]                        = "`r0";
$OP::Key["LargeGrass"]                   = "`r1";
$OP::Key["Grass02Small"]                 = "`r2";
$OP::Key["Grass02DenseSmall"]            = "`r3";
$OP::Key["Grass02DenseLarge"]            = "`r4";
$OP::Key["NaturalPlant"]                 = "`r5";
$OP::Key["VinesWideLong"]                = "`r6";
$OP::Key["VinesWideShort"]               = "`r7";
$OP::Key["VinesThinLong"]                = "`r8";
$OP::Key["VinesThinShort"]               = "`r9";
$OP::Key["Tree01"]                       = "`s0";
$OP::Key["Tree02"]                       = "`s1";
$OP::Key["Tree03"]                       = "`s2";
$OP::Key["TreeBare01"]                   = "`s3";
$OP::Key["TreeBare02"]                   = "`s4";
$OP::Key["TreeBare03"]                   = "`s5";
$OP::Key["EffectPlant"]                  = "`s6";


$OP::Key["`c0"] = "dataBlock";
$OP::Key["`c1"] = "position";
$OP::Key["`c2"] = "rotation";
$OP::Key["`c3"] = "scale";
$OP::Key["`c4"] = "interiorFile";
$OP::Key["`c5"] = "polyhedron";
$OP::Key["`c6"] = "showTerrainInside";
$OP::Key["`c7"] = "collideable";
$OP::Key["`c8"] = "static";
$OP::Key["`c9"] = "rotate";
$OP::Key["`d0"] = "GemItemRed";
$OP::Key["`d1"] = "GemItemYellow";
$OP::Key["`d2"] = "GemItemBlue";
$OP::Key["`d3"] = "SpawnTrigger";
$OP::Key["`d4"] = "0.0000000 0.0000000 0.0000000 1.0000000 0.0000000 0.0000000 0.0000000 -1.0000000 0.0000000 0.0000000 0.0000000 1.0000000";
$OP::Key["`d5"] = "1 1 1";
$OP::Key["`d6"] = "1 0 0 0";
$OP::Key["`d7"] = "0 0 1";
$OP::Key["`d8"] = "HelicopterItem";
$OP::Key["`d9"] = "DuctFan";
$OP::Key["`e0"] = "SuperSpeedItem";
$OP::Key["`e1"] = "SuperJumpItem";
$OP::Key["`e2"] = "MegaMarbleItem";
$OP::Key["`e3"] = "BlastItem";
$OP::Key["`e4"] = "/data/multiplayer/interiors";
$OP::Key["`e5"] = ".dif";
$OP::Key["`e6"] = ".dts";
$OP::Key["`e7"] = "//--- OBJECT WRITE BEGIN ---";
$OP::Key["`e8"] = "//--- OBJECT WRITE END ---";
$OP::Key["`f0"] = "RandomPowerUpItem";
$OP::Key["`f1"] = "FireBallItem";
$OP::Key["`f2"] = "CustomSuperJumpItem_PQ";
$OP::Key["`f3"] = "AntiGravityItem_PQ";
$OP::Key["`f4"] = "SuperJumpItem_PQ";
$OP::Key["`f5"] = "SuperBounceItem_PQ";
$OP::Key["`f6"] = "SuperSpeedItem_PQ";
$OP::Key["`f7"] = "ShockAbsorberItem_PQ";
$OP::Key["`f8"] = "HelicopterItem_PQ";
$OP::Key["`f9"] = "TimeTravelItem_PQ";
$OP::Key["`l0"] = "RespawningTimeTravelItem";
$OP::Key["`l1"] = "RespawningTimePenaltyItem";
$OP::Key["`l2"] = "RespawningTimeTravelItem_PQ";
$OP::Key["`l3"] = "RespawningTimePenaltyItem_PQ";
$OP::Key["`l4"] = "easterEgg";
$OP::Key["`l5"] = "GemItem";
$OP::Key["`l6"] = "GemItemPurple";
$OP::Key["`l7"] = "GemItemGreen";
$OP::Key["`l8"] = "GemItemTurquoise";
$OP::Key["`l9"] = "GemItemOrange";
$OP::Key["`m0"] = "GemItemBlack";
$OP::Key["`m1"] = "GemItemPlatinum";
$OP::Key["`m2"] = "GemItem_PQ";
$OP::Key["`m3"] = "GemItemBlue_PQ";
$OP::Key["`m4"] = "GemItemRed_PQ";
$OP::Key["`m5"] = "GemItemYellow_PQ";
$OP::Key["`m6"] = "GemItemPurple_PQ";
$OP::Key["`m7"] = "GemItemGreen_PQ";
$OP::Key["`m8"] = "GemItemTurquoise_PQ";
$OP::Key["`m9"] = "GemItemOrange_PQ";
$OP::Key["`n0"] = "GemItemBlack_PQ";
$OP::Key["`n1"] = "GemItemPlatinum_PQ";
$OP::Key["`n2"] = "FancyGemItem_PQ";
$OP::Key["`n3"] = "NestEgg_PQ";
$OP::Key["`n4"] = "NoRespawnAntiGravityItem";
$OP::Key["`n5"] = "NoRespawnAntiGravityItem_PQ";
$OP::Key["`n6"] = "TeleportItem";
$OP::Key["`n7"] = "AnvilItem";
$OP::Key["`n8"] = "BubbleItem";
$OP::Key["`n9"] = "FadePlatform";
$OP::Key["`o0"] = "FadePlatform2_1x1";
$OP::Key["`o1"] = "FadePlatform2_1x2";
$OP::Key["`o2"] = "FadePlatform2_1x3";
$OP::Key["`o3"] = "FadePlatform2_1x5";
$OP::Key["`o4"] = "FadePlatform2_2x2";
$OP::Key["`o5"] = "FadePlatform2_3x3";
$OP::Key["`o6"] = "FadePlatform2_5x5";
$OP::Key["`o7"] = "FadePlatformConcrete";
$OP::Key["`o8"] = "FadePlatformGrass";
$OP::Key["`o9"] = "FadePlatformIce";
$OP::Key["`p0"] = "target";
$OP::Key["`p1"] = "DefaultCannon";
$OP::Key["`p2"] = "Cannon_Low";
$OP::Key["`p3"] = "Cannon_Mid";
$OP::Key["`p4"] = "Cannon_High";
$OP::Key["`p5"] = "Cannon_Custom";
$OP::Key["`p6"] = "DefaultCannonBase";
$OP::Key["`p7"] = "HelpBubble";
$OP::Key["`p8"] = "Fence_1TilesLength";
$OP::Key["`p9"] = "Fence_2TilesLength";
$OP::Key["`q0"] = "Fence_3TilesLength";
$OP::Key["`q1"] = "Fence_4TilesLength";
$OP::Key["`q2"] = "Fence_5TilesLength";
$OP::Key["`q3"] = "FencePole";
$OP::Key["`q4"] = "Plant01";
$OP::Key["`q5"] = "Fern01";
$OP::Key["`q6"] = "Floweres";
$OP::Key["`q7"] = "Tulip";
$OP::Key["`q8"] = "Scarce_Tulips";
$OP::Key["`q9"] = "Dense_Tulips";
$OP::Key["`r0"] = "grass";
$OP::Key["`r1"] = "LargeGrass";
$OP::Key["`r2"] = "Grass02Small";
$OP::Key["`r3"] = "Grass02DenseSmall";
$OP::Key["`r4"] = "Grass02DenseLarge";
$OP::Key["`r5"] = "NaturalPlant";
$OP::Key["`r6"] = "VinesWideLong";
$OP::Key["`r7"] = "VinesWideShort";
$OP::Key["`r8"] = "VinesThinLong";
$OP::Key["`r9"] = "VinesThinShort";
$OP::Key["`s0"] = "Tree01";
$OP::Key["`s1"] = "Tree02";
$OP::Key["`s2"] = "Tree03";
$OP::Key["`s3"] = "TreeBare01";
$OP::Key["`s4"] = "TreeBare02";
$OP::Key["`s5"] = "TreeBare03";
$OP::Key["`s6"] = "EffectPlant";


//-----------------------------------------------------------------------------

$OP::Key["radiusFromGem"]  = "`h0";
$OP::Key["alarmStartTime"] = "`h1";
$OP::Key["platinumScore"]  = "`h2";
$OP::Key["ultimateScore"]  = "`h3";
$OP::Key["overviewHeight"] = "`h4";

$OP::Key["`h0"] = "radiusFromGem";
$OP::Key["`h1"] = "alarmStartTime";
$OP::Key["`h2"] = "platinumScore";
$OP::Key["`h3"] = "ultimateScore";
$OP::Key["`h4"] = "overviewHeight";

//-----------------------------------------------------------------------------

$OP::Key["cloudHeightPer"]          = "`i0";
$OP::Key["cloudSpeed1"]             = "`i1";
$OP::Key["cloudSpeed2"]             = "`i2";
$OP::Key["cloudSpeed3"]             = "`i3";
$OP::Key["visibleDistance"]         = "`i4";
$OP::Key["useSkyTextures"]          = "`i5";
$OP::Key["renderBottomTexture"]     = "`i6";
$OP::Key["SkySolidColor"]           = "`i7";
$OP::Key["fogDistance"]             = "`i8";
$OP::Key["fogColor"]                = "`i9";
$OP::Key["fogVolume1"]              = "`j0";
$OP::Key["fogVolume2"]              = "`j1";
$OP::Key["fogVolume3"]              = "`j2";
$OP::Key["materialList"]            = "`j3";
$OP::Key["windVelocity"]            = "`j4";
$OP::Key["windEffectPrecipitation"] = "`j5";
$OP::Key["noRenderBans"]            = "`j6";
$OP::Key["fogVolumeColor1"]         = "`j7";
$OP::Key["fogVolumeColor2"]         = "`j8";
$OP::Key["fogVolumeColor3"]         = "`j9";

$OP::Key["`i0"] = "cloudHeightPer";
$OP::Key["`i1"] = "cloudSpeed1";
$OP::Key["`i2"] = "cloudSpeed2";
$OP::Key["`i3"] = "cloudSpeed3";
$OP::Key["`i4"] = "visibleDistance";
$OP::Key["`i5"] = "useSkyTextures";
$OP::Key["`i6"] = "renderBottomTexture";
$OP::Key["`i7"] = "SkySolidColor";
$OP::Key["`i8"] = "fogDistance";
$OP::Key["`i9"] = "fogColor";
$OP::Key["`j0"] = "fogVolume1";
$OP::Key["`j1"] = "fogVolume2";
$OP::Key["`j2"] = "fogVolume3";
$OP::Key["`j3"] = "materialList";
$OP::Key["`j4"] = "windVelocity";
$OP::Key["`j5"] = "windEffectPrecipitation";
$OP::Key["`j6"] = "noRenderBans";
$OP::Key["`j7"] = "fogVolumeColor1";
$OP::Key["`j8"] = "fogVolumeColor2";
$OP::Key["`j9"] = "fogVolumeColor3";

//-----------------------------------------------------------------------------
//Suddenly Super Duper Space (literally!) Saver!

$OP::Key["                              "] = "`k0";
$OP::Key["                           "]    = "`k1";
$OP::Key["                        "]       = "`k2";
$OP::Key["                     "]          = "`k3";
$OP::Key["                  "]             = "`k4";
$OP::Key["               "]                = "`k5";
$OP::Key["            "]                   = "`k6";
$OP::Key["         "]                      = "`k7";
$OP::Key["      "]                         = "`k8";
$OP::Key["   "]                            = "`k9";

$OP::Key["`k0"] = "                              ";
$OP::Key["`k1"] = "                           ";
$OP::Key["`k2"] = "                        ";
$OP::Key["`k3"] = "                     ";
$OP::Key["`k4"] = "                  ";
$OP::Key["`k5"] = "               ";
$OP::Key["`k6"] = "            ";
$OP::Key["`k7"] = "         ";
$OP::Key["`k8"] = "      ";
$OP::Key["`k9"] = "   ";

//-----------------------------------------------------------------------------

///@summary reads a mission file and encodes it before sending it to the stream
///@param file the location of the mission file to encode
///@return the encoded seralized data
function encodeMission(%file) {
	// read file
	%data = fread(%file);
	%data = strReplace(%data, "\n", "\r\n");

	// encode Keys with OP codes
	for (%i = 0; %i < 20; %i ++) {
		for (%j = 0; %j < 10; %j ++) {
			%word = $OP::Key["`" @ strlet(%i) @ %j];
			if (%word !$= "")
				%data = strReplace(%data, %word, $OP::Key[%word]);
		}
	}

	return %data;
}

///@summary decodes a mission from the data stream and writes it out to a file
///@param fileName the location to where to write the file
///@param data the contents to be written
function decodeMission(%fileName, %data) {
	// decodes OP codes with Keys
	for (%i = 0; %i < 20; %i ++) {
		for (%j = 0; %j < 10; %j ++) {
			%word = "`" @ strlet(%i) @ %j;
			%data = strReplace(%data, %word, $OP::Key[%word]);
		}
	}

	// write file
	fwrite(%fileName, %data);
}