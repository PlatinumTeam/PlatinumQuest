//-----------------------------------------------------------------------------
// Portions Copyright (c) 2021 The Platinum Team
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

//-----------------------------------------------------------------------------
// Torque Game Engine
//
// Portions Copyright (c) 2001 GarageGames.Com
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
//-----------------------------------------------------------------------------

function portInit(%port) {
	%failCount = 0;
	while (%failCount < 14 && !setNetPort(%port)) {
		echo("Port init failed on port " @ %port @ " trying next port.");
		%port++;
		%failCount++;
	}
}

function createServer(%serverType) {
	destroyServer();

	//
	$missionSequence = 0;
	$Server::Hosting = true;
	$Server::PlayerCount = 0;
	$Server::ServerType = %serverType;
	$Server::Started = false;

	// Setup for multi-player, the network must have been
	// initialized before now.
	if (%serverType $= "MultiPlayer") {
//      echo("Starting multiplayer mode");

		// Make sure the network port is set to the correct pref.
		portInit($Pref::Server::Port);
		allowConnections(true);

		// Banlists
		loadBanlist();

		if ($pref::Net::DisplayOnMaster !$= "Never")
			onNextFrame(startHeartbeat);
	}

	// Load the mission
	$ServerGroup = new SimGroup(ServerGroup);
	onServerCreated();
	initServerCRC();

	if (!isObject(FakeClientGroup))
		RootGroup.add(new SimGroup(FakeClientGroup));
}


//-----------------------------------------------------------------------------

function destroyServer() {
	$Server::ServerType = "";
	$Server::Hosting = false;
	$Server::Loaded = false;
	$Server::Loading = false;
	$missionRunning = false;
	allowConnections(false);
	stopHeartbeat();

	//Write this
	saveBanlist();
	BanList.delete();

	// Clean up the game scripts
	onServerDestroyed();

	// Delete all the server objects
	while (isObject(MissionGroup))
		MissionGroup.delete();
	while (isObject(MissionCleanup))
		MissionCleanup.delete();
	while (isObject(FXGroup))
		FXGroup.delete();
	while (isObject($ServerGroup))
		$ServerGroup.delete();
	while (isObject(MissionInfo))
		MissionInfo.delete();
	while (isObject(FakeClientGroup))
		FakeClientGroup.delete();

	// Delete all the connections:
	while (ClientGroup.getCount()) {
		%client = ClientGroup.getObject(0);
		%client.delete("SERVER_CLOSE");
	}

	$Server::GuidList = "";

	// Delete all the data blocks...
	if (!$quitting) {
		deleteDataBlocks();
	}

	// Save any server settings

	// Dump anything we're not using
	purgeResources();
}


//--------------------------------------------------------------------------

function resetServerDefaults() {
	echo("Resetting server defaults...");

	// Override server defaults with prefs:
//   exec( "~/core/defaults.cs" );
//   exec( "~/core/mbpPrefs.cs" );

	loadMission($Server::MissionFile);
}


//------------------------------------------------------------------------------
// Guid list maintenance functions:
function addToServerGuidList(%guid) {
	%count = getFieldCount($Server::GuidList);
	for (%i = 0; %i < %count; %i++) {
		if (getField($Server::GuidList, %i) == %guid)
			return;
	}

	$Server::GuidList = $Server::GuidList $= "" ? %guid : $Server::GuidList TAB %guid;
}

function removeFromServerGuidList(%guid) {
	%count = getFieldCount($Server::GuidList);
	for (%i = 0; %i < %count; %i++) {
		if (getField($Server::GuidList, %i) == %guid) {
			$Server::GuidList = removeField($Server::GuidList, %i);
			return;
		}
	}

	// Huh, didn't find it.
}


//-----------------------------------------------------------------------------

function onServerInfoQuery() {
	// When the server is queried for information, the value
	// of this function is returned as the status field of
	// the query packet.  This information is accessible as
	// the ServerInfo::State variable.

	$Server::PlayerCount = getRealPlayerCount();

	// Server::GameType is sent to the master server.
	// This variable should uniquely identify your game and/or mod.
	//
	// Server::MissionType sent to the master server.  Clients can
	// filter servers based on mission type.

	//We don't give a crap about their lovely setup, though. I don't want to
	// write a huffman processor in PHP, so I'm just going to send a bunch of
	// information in these variables.

	$Server::GameType =
	    "Platinum" TAB
	    ($MP::TeamMode ? "Teams" : "FFA") TAB
	    0 TAB
	    ($Server::Dedicated ? "No Host" : $LB::Username) TAB
	    ($MPPref::Server::Password !$= "");

	$Server::MissionType =
	    $Pref::Server::Port TAB
	    $Pref::Server::Name TAB
	    ($Server::Lobby ? "Lobby" : MissionInfo.name);

	return ($Server::Lobby ? "Lobby" : "Playing");
}

