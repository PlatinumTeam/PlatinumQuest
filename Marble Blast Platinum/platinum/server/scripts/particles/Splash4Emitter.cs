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
datablock ParticleData(Splash4Particle) {
	dragCoefficient = "5.71236";
	windCoefficient = "0";
	gravityCoefficient = "-0.176471";
	inheritedVelFactor = "0";
	constantAcceleration = "0";
	lifetimeMS = "618";
	lifetimeVarianceMS = "96";
	spinSpeed = "10";
	spinRandomMin = "-90";
	spinRandomMax = "156.863";
	useInvAlpha = "0";
	animateTexture = "0";
	framesPerSec = "1";
	textureName = "platinum/data/particles/splash1";
	animTexName[0] = "platinum/data/particles/splash1";
	colors[0] = "0.843137 0.833333 0.843137 0.441176";
	colors[1] = "0.784314 0.813725 0.882353 0.686275";
	colors[2] = "0.843137 0.862745 0.892157 0.264706";
	colors[3] = "0.892157 0.911765 0.980392 0.000000";
	sizes[0] = "0.25";
	sizes[1] = "0.25";
	sizes[2] = "0.34";
	sizes[3] = "0.34";
	times[0] = "0";
	times[1] = "0.28";
	times[2] = "0.73";
	times[3] = "1";
	dragCoeffiecient = "1";
};

//--- Emitter ---
datablock ParticleEmitterData(Splash4Emitter) {
	className = "ParticleEmitterData";
	ejectionPeriodMS = "49";
	periodVarianceMS = "48";
	ejectionVelocity = "0";
	velocityVariance = "0";
	ejectionOffset = "0.294118";
	thetaMin = "0";
	thetaMax = "37.0588";
	phiReferenceVel = "0";
	phiVariance = "360";
	overrideAdvance = "1";
	orientParticles = "0";
	orientOnVelocity = "1";
	particles = "Splash4Particle";
	lifetimeMS = "0";
	lifetimeVarianceMS = "0";
	useEmitterSizes = "0";
	useEmitterColors = "0";
	dragCoefficient = "5.71219";
};
