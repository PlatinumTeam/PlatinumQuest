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
datablock ParticleData(SnoreParticle) {
	dragCoefficient = "0.9975";
	windCoefficient = "0";
	gravityCoefficient = "-0.0525";
	inheritedVelFactor = "0";
	constantAcceleration = "0";
	lifetimeMS = "3000";
	lifetimeVarianceMS = "475";
	spinSpeed = "0";
	spinRandomMin = "0";
	spinRandomMax = "0";
	useInvAlpha = "0";
	animateTexture = "0";
	framesPerSec = "1";
	textureName = "";
	animTexName[0] = "platinum/data/particles/zzz";
	colors[0] = "0.787402 1.000000 0.787402 1.000000";
	colors[1] = "0.787402 1.000000 0.787402 1.000000";
	colors[2] = "1.000000 1.000000 1.000000 0.000000";
	colors[3] = "1.000000 1.000000 1.000000 1.000000";
	sizes[0] = "0";
	sizes[1] = "0.5";
	sizes[2] = "0";
	sizes[3] = "1";
	times[0] = "0";
	times[1] = "0.15";
	times[2] = "1";
	times[3] = "1";
};

//--- Emitter ---
datablock ParticleEmitterData(MarbleSnoreEmitter) {
	className = "ParticleEmitterData";
	ejectionPeriodMS = "1500";
	periodVarianceMS = "300";
	ejectionVelocity = "0.2";
	velocityVariance = "0.05";
	ejectionOffset = "0.2";
	thetaMin = "7.5";
	thetaMax = "45";
	phiReferenceVel = "20";
	phiVariance = "0";
	overrideAdvance = "0";
	orientParticles = "0";
	orientOnVelocity = "1";
	particles = "SnoreParticle";
	lifetimeMS = "0";
	lifetimeVarianceMS = "0";
	useEmitterSizes = "0";
	useEmitterColors = "0";
};
