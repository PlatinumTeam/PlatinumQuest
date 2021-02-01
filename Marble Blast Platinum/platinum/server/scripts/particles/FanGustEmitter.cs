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
datablock ParticleData(FanGustParticle) {
	dragCoefficient = "0.581623";
	windCoefficient = "0";
	gravityCoefficient = "-0.00732601";
	inheritedVelFactor = "0.46771";
	constantAcceleration = "0";
	lifetimeMS = "800";
	lifetimeVarianceMS = "96";
	spinSpeed = "4.21569";
	spinRandomMin = "-100";
	spinRandomMax = "93";
	useInvAlpha = "1";
	animateTexture = "0";
	framesPerSec = "1";
	textureName = "";
	animTexName[0] = "platinum/data/particles/gust";
	colors[0] = "0.803150 0.779528 0.803150 0.000000";
	colors[1] = "0.732283 0.700787 0.661417 0.362205";
	colors[2] = "0.748031 0.732283 0.732283 0.346457";
	colors[3] = "0.763780 0.755906 0.724409 0.000000";
	sizes[0] = "0.875908";
	sizes[1] = "3.72642";
	sizes[2] = "3.42428";
	sizes[3] = "2.35";
	times[0] = "0";
	times[1] = "0.176471";
	times[2] = "0.458824";
	times[3] = "1";
	dragCoeffiecient = "1";
};

//--- Emitter ---
datablock ParticleEmitterData(FanGustEmitter) {
	className = "ParticleEmitterData";
	ejectionPeriodMS = "79";
	periodVarianceMS = "78";
	ejectionVelocity = "10.28";
	velocityVariance = "0.87";
	ejectionOffset = "0";
	thetaMin = "67";
	thetaMax = "112";
	phiReferenceVel = "0";
	phiVariance = "42.3529";
	overrideAdvance = "0";
	orientParticles = "0";
	orientOnVelocity = "0";
	particles = "FanGustParticle";
	lifetimeMS = "0";
	lifetimeVarianceMS = "0";
	useEmitterSizes = "0";
	useEmitterColors = "0";
};
