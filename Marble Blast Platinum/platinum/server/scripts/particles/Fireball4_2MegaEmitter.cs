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

datablock ParticleData(Fireball4_2MegaParticle) {
	dragCoefficient = "2.54902";
	windCoefficient = "0";
	gravityCoefficient = "0.215686";
	inheritedVelFactor = "0";
	constantAcceleration = "0";
	lifetimeMS = "150";
	lifetimeVarianceMS = "0";
	spinSpeed = "10";
	spinRandomMin = "-100";
	spinRandomMax = "0.5";
	useInvAlpha = "0";
	animateTexture = "0";
	framesPerSec = "1";
	textureName = "platinum/data/particles/fireball_4";
	animTexName[0] = "platinum/data/particles/fireball_4";
	colors[0] = "0.843137 0.833333 0.843137 0.000000";
	colors[1] = "0.784314 0.813725 0.882353 1.000000";
	colors[2] = "0.843137 0.862745 0.892157 0.000000";
	colors[3] = "0.892157 0.911765 0.980392 0.000000";
	sizes[0] = "2.7";
	sizes[1] = "1.8";
	sizes[2] = "0";
	sizes[3] = "3.0";
	times[0] = "0";
	times[1] = "0.14";
	times[2] = "0.72";
	times[3] = "1";
	dragCoeffiecient = "1";
};

//--- Emitter ---

datablock ParticleEmitterData(Fireball4_2MegaEmitter) {
	className = "ParticleEmitterData";
	ejectionPeriodMS = "1";
	periodVarianceMS = "0";
	ejectionVelocity = "0";
	velocityVariance = "0";
	ejectionOffset = "0";
	thetaMin = "0";
	thetaMax = "61.7647";
	phiReferenceVel = "0";
	phiVariance = "360";
	overrideAdvance = "0";
	orientParticles = "0";
	orientOnVelocity = "1";
	particles = "Fireball4_2MegaParticle";
	lifetimeMS = "0";
	lifetimeVarianceMS = "0";
	useEmitterSizes = "0";
	useEmitterColors = "0";
};
