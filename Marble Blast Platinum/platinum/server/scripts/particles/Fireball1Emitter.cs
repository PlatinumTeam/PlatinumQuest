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

datablock ParticleData(Fireball1Particle) {
	dragCoefficient = "1.17647";
	windCoefficient = "0";
	gravityCoefficient = "0.156863";
	inheritedVelFactor = "0";
	constantAcceleration = "0";
	lifetimeMS = "480";
	lifetimeVarianceMS = "96";
	spinSpeed = "6.47059";
	spinRandomMin = "-90";
	spinRandomMax = "210.784";
	useInvAlpha = "0";
	animateTexture = "0";
	framesPerSec = "1";
	textureName = "platinum/data/particles/fireball_1";
	animTexName[0] = "platinum/data/particles/fireball_1";
	colors[0] = "0.843137 0.715686 0.666667 0.000000";
	colors[1] = "0.784314 0.607843 0.529412 1.000000";
	colors[2] = "0.882353 0.529412 0.372549 0.588235";
	colors[3] = "0.892157 0.911765 0.980392 0.000000";
	sizes[0] = "0.1";
	sizes[1] = "0.24";
	sizes[2] = "1.08";
	sizes[3] = "1.91";
	times[0] = "0";
	times[1] = "0.28";
	times[2] = "0.74";
	times[3] = "1";
	dragCoeffiecient = "1";
};

//--- Emitter ---

datablock ParticleEmitterData(Fireball1Emitter) {
	className = "ParticleEmitterData";
	ejectionPeriodMS = "2";
	periodVarianceMS = "0";
	ejectionVelocity = "3.92157";
	velocityVariance = "0.05";
	ejectionOffset = "0.2";
	thetaMin = "0";
	thetaMax = "180";
	phiReferenceVel = "0";
	phiVariance = "360";
	overrideAdvance = "0";
	orientParticles = "0";
	orientOnVelocity = "1";
	particles = "Fireball1Particle";
	lifetimeMS = "98";
	lifetimeVarianceMS = "0";
	useEmitterSizes = "0";
	useEmitterColors = "0";
};
