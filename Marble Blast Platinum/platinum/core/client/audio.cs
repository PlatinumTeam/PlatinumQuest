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

function OpenALInit() {
	OpenALShutdownDriver();

	echo("");
	echo("OpenAL Driver Init:");

	echo($pref::Audio::driver);

	if ($pref::Audio::driver $= "OpenAL") {
		if (!OpenALInitDriver()) {
			error("   Failed to initialize driver.");
			$Audio::initFailed = true;
		}
	}

	echo("   Vendor: " @ alGetString("AL_VENDOR"));
	echo("   Version: " @ alGetString("AL_VERSION"));
	echo("   Renderer: " @ alGetString("AL_RENDERER"));
	echo("   Extensions: " @ alGetString("AL_EXTENSIONS"));

	alxListenerf(AL_GAIN_LINEAR, $pref::Audio::masterVolume);

	for (%channel = 1; %channel <= 8; %channel ++)
		alxSetChannelVolume(%channel, $pref::Audio::channelVolume[%channel]);

	echo("");
}


//--------------------------------------------------------------------------

function OpenALShutdown() {
	OpenALShutdownDriver();
	//alxStopAll();
	//AudioGui.delete();
	//sButtonDown.delete();
	//sButtonOver.delete();
}
