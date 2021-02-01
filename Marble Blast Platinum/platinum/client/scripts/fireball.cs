//-----------------------------------------------------------------------------
// Client-Side Fireball PowerUp for MBPQ
//
// Copyright (c) 2015 The Platinum Team
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

function clientCmdFireballInit(%time) {
	$Client::FireballStartTime = getSimTime();
	$Client::FireballActiveTime = %time;
	$Client::FireballTime = %time;
	//So we can instantly blast after getting a new fireball
	$Client::FireballLastBlastTime = 0;

	$Client::FireballActive = true;

	//Disable bubble
	ActivateBubble(false);

	PlayGui.updateFireballBar();
}

function clientCmdSetFireballTime(%time) {
	$Client::FireballTime = %time;
}

function clientCmdFireballExpire() {
	$Client::FireballActive = false;

	PlayGui.updateFireballBar();
}

function fireballBlast() {
	%time = $Client::FireballTime - (getSimTime() - $Client::FireballStartTime);
	//check for cooldown is active OR time < 1000; if so, return
	if (%time < 1000 || (getSimTime() - $Client::FireballLastBlastTime < 2000))
		return false;

	commandToServer('FireballBlast');

	//boost marble upwards (base impulse of 2 + fraction of 5 (after jump) + fraction of 5 based on last 400 ms since jump)

	//Basically, if you just jumped, the fireball will be less powerful so you can't combine for crazy height
	%scale2 = ($Sim::Time - $Game::LastJumpTime) / 0.400;
	if (%scale2 > 1)
		%scale2 = 1;
	%scale = (%time / $Client::FireballActiveTime) * 5 + (%scale2 * 5) + 2;
	%gravity = getGravityDir();
	%push = VectorScale(VectorNormalize(%gravity), -%scale);

	$MP::MyMarble.applyImpulse("0 0 0", %push);

	$Client::FireballLastBlastTime = getSimTime();
	return true;
}

function clientCmdFireballStartParticles(%index) {
	cancel($Client::FireballSchedule[%index]);
	updateMarbleIds();
	%player = PlayerList.getEntry(%index).player;

	if (isObject(%player)) {
		PlayerList.getEntry(%index).player.fireball = true;
	} else {
		$Client::FireballSchedule[%index] = schedule(100, 0, clientCmdFireballStartParticles, %index);
	}
}

function clientCmdFireballEndParticles(%index) {
	PlayerList.getEntry(%index).player.fireball = false;
}