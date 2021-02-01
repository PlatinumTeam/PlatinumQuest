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
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
//-----------------------------------------------------------------------------


//--- Particle ---
datablock ParticleData(AssemblyLineFireParticle) {
	dragCoefficient = "0";
	windCoefficient = "1";
	gravityCoefficient = "-0.00732601";
	inheritedVelFactor = "0.248532";
	constantAcceleration = "-0.8";
	lifetimeMS = "1184";
	lifetimeVarianceMS = "288";
	spinSpeed = "0";
	spinRandomMin = "-80";
	spinRandomMax = "196.078";
	useInvAlpha = "1";
	animateTexture = "0";
	framesPerSec = "1";
	textureName = "platinum/data/particles/smoke";
	animTexName[0] = "platinum/data/particles/smoke";
	colors[0] = "0.551181 0.354331 0.251969 1.000000";
	colors[1] = "0.188976 0.188976 0.188976 1.000000";
	colors[2] = "0.000000 0.000000 0.000000 0.000000";
	colors[3] = "1.000000 1.000000 1.000000 1.000000";
	sizes[0] = "0.99";
	sizes[1] = "1.5";
	sizes[2] = "2";
	sizes[3] = "1";
	times[0] = "0";
	times[1] = "0.5";
	times[2] = "1";
	times[3] = "1";
	dragCoeffiecient = "100";
};

//--- Emitter ---
datablock ParticleData(AssemblyLineFireEmitter) {
	dragCoefficient = "0";
	windCoefficient = "1";
	gravityCoefficient = "-0.00732601";
	inheritedVelFactor = "0.248532";
	constantAcceleration = "-0.8";
	lifetimeMS = "1184";
	lifetimeVarianceMS = "288";
	spinSpeed = "0";
	spinRandomMin = "-80";
	spinRandomMax = "196.078";
	useInvAlpha = "1";
	animateTexture = "0";
	framesPerSec = "1";
	textureName = "platinum/data/particles/smoke";
	animTexName[0] = "platinum/data/particles/smoke";
	colors[0] = "0.551181 0.354331 0.251969 1.000000";
	colors[1] = "0.188976 0.188976 0.188976 1.000000";
	colors[2] = "0.000000 0.000000 0.000000 0.000000";
	colors[3] = "1.000000 1.000000 1.000000 1.000000";
	sizes[0] = "0.99";
	sizes[1] = "1.5";
	sizes[2] = "2";
	sizes[3] = "1";
	times[0] = "0";
	times[1] = "0.5";
	times[2] = "1";
	times[3] = "1";
	dragCoeffiecient = "100";
};
