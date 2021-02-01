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


//--- Particle ---
datablock ParticleData(Splash3Particle) {
	dragCoefficient = "2.54902";
	windCoefficient = "0";
	gravityCoefficient = "0.705882";
	inheritedVelFactor = "0";
	constantAcceleration = "0";
	lifetimeMS = "1009";
	lifetimeVarianceMS = "96";
	spinSpeed = "1";
	spinRandomMin = "-90";
	spinRandomMax = "0.5";
	useInvAlpha = "1";
	animateTexture = "0";
	framesPerSec = "1";
	textureName = "platinum/data/particles/splash1";
	animTexName[0] = "platinum/data/particles/splash3";
	colors[0] = "0.843137 0.833333 0.843137 0.441176";
	colors[1] = "0.784314 0.813725 0.882353 0.686275";
	colors[2] = "0.843137 0.862745 0.892157 0.264706";
	colors[3] = "0.892157 0.911765 0.980392 0.000000";
	sizes[0] = "0.64";
	sizes[1] = "0.64";
	sizes[2] = "1";
	sizes[3] = "1";
	times[0] = "0";
	times[1] = "0.28";
	times[2] = "0.73";
	times[3] = "1";
	dragCoeffiecient = "1";
};

//--- Emitter ---
datablock ParticleEmitterData(Splash3Emitter) {
	className = "ParticleEmitterData";
	ejectionPeriodMS = "1";
	periodVarianceMS = "0";
	ejectionVelocity = "10.5882";
	velocityVariance = "0.05";
	ejectionOffset = "0.588235";
	thetaMin = "0";
	thetaMax = "61.7647";
	phiReferenceVel = "0";
	phiVariance = "360";
	overrideAdvance = "0";
	orientParticles = "0";
	orientOnVelocity = "1";
	particles = "Splash3Particle";
	lifetimeMS = "98";
	lifetimeVarianceMS = "0";
	useEmitterSizes = "0";
	useEmitterColors = "0";
};
