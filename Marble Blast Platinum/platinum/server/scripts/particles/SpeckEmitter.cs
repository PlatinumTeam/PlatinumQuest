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
datablock ParticleData(SpeckParticle) {
	dragCoefficient = "0";
	windCoefficient = "0";
	gravityCoefficient = "0";
	inheritedVelFactor = "0";
	constantAcceleration = "-5";
	lifetimeMS = "911";
	lifetimeVarianceMS = "96";
	spinSpeed = "6.86275";
	spinRandomMin = "-90";
	spinRandomMax = "161.765";
	useInvAlpha = "1";
	animateTexture = "0";
	framesPerSec = "1";
	textureName = "platinum/data/particles/speck";
	animTexName[0] = "platinum/data/particles/speck";
	colors[0] = "0.441176 0.333333 0.088235 0.000000";
	colors[1] = "0.745098 0.568627 0.382353 0.000000";
	colors[2] = "0.735294 0.607843 0.460784 0.280000";
	colors[3] = "0.774510 0.676471 0.490196 1.000000";
	sizes[0] = "0.78";
	sizes[1] = "1";
	sizes[2] = "1";
	sizes[3] = "0";
	times[0] = "0";
	times[1] = "0.24";
	times[2] = "0.39";
	times[3] = "1";
	dragCoeffiecient = "1";
};

//--- Emitter ---
datablock ParticleEmitterData(SpeckEmitter) {
	className = "ParticleEmitterData";
	ejectionPeriodMS = "10";
	periodVarianceMS = "9";
	ejectionVelocity = "11.5686";
	velocityVariance = "0.686275";
	ejectionOffset = "6.27451";
	thetaMin = 236.471 - 180;
	thetaMax = 307.059 - 180;
	phiReferenceVel = "0";
	phiVariance = "360";
	overrideAdvance = "0";
	orientParticles = "0";
	orientOnVelocity = "1";
	particles = "SpeckParticle";
	lifetimeMS = "0";
	lifetimeVarianceMS = "0";
	useEmitterSizes = "0";
	useEmitterColors = "0";
};
