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
datablock ParticleData(EmptyParticle) {
	dragCoefficient = "0";
	windCoefficient = "0";
	gravityCoefficient = "0";
	inheritedVelFactor = "0";
	constantAcceleration = "0";
	lifetimeMS = "0";
	lifetimeVarianceMS = "0";
	spinSpeed = "0";
	spinRandomMin = "0";
	spinRandomMax = "0";
	useInvAlpha = "1";
	animateTexture = "0";
	framesPerSec = "1";
	textureName = "platinum/data/particles/orb";
	animTexName[0] = "platinum/data/particles/orb";
	colors[0] = "0 0 1 0.5";
	colors[1] = "0 1 0 0.5";
	colors[2] = "0.7 0.7 0 0.5";
	colors[3] = "1 0.2 0.2 0.5";
	sizes[0] = "0";
	sizes[1] = "0";
	sizes[2] = "0";
	sizes[3] = "0";
	times[0] = "0";
	times[1] = "0.25";
	times[2] = "0.5";
	times[3] = "0.75";
	dragCoeffiecient = "1";
};

//--- Emitter ---
datablock ParticleEmitterData(EmptyEmitter) {
	className = "ParticleEmitterData";
	ejectionPeriodMS = "10000";
	periodVarianceMS = "0";
	ejectionVelocity = "0";
	velocityVariance = "0";
	ejectionOffset = "0";
	thetaMin = "0";
	thetaMax = "180";
	phiReferenceVel = "0";
	phiVariance = "360";
	overrideAdvance = "1";
	orientParticles = "0";
	orientOnVelocity = "0";
	particles = "EmptyParticle";
	lifetimeMS = "0";
	lifetimeVarianceMS = "0";
	useEmitterSizes = "0";
	useEmitterColors = "0";
};
