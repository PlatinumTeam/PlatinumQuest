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
datablock ParticleData(IceShardShineParticle) {
	dragCoefficient = "10";
	windCoefficient = "0";
	gravityCoefficient = "0";
	inheritedVelFactor = "0";
	constantAcceleration = "0";
	lifetimeMS = "1500";
	lifetimeVarianceMS = "100";
	spinSpeed = "0";
	spinRandomMin = "0";
	spinRandomMax = "0";
	useInvAlpha = "1";
	animateTexture = "0";
	framesPerSec = "1";
	textureName = "";
	animTexName[0] = "platinum/data/particles/glint2";
	colors[0] = "0.852941 0.911765 1.000000 0.000000";
	colors[1] = "0.862745 0.901961 1.000000 0.000000";
	colors[2] = "0.862745 0.892157 1.000000 1.000000";
	colors[3] = "0.862745 0.892157 1.000000 0.000000";
	sizes[0] = "0.15";
	sizes[1] = "0";
	sizes[2] = "0.15";
	sizes[3] = "0";
	times[0] = "0";
	times[1] = "0.78";
	times[2] = "0.88";
	times[3] = "1";
	dragCoeffiecient = "0.1";
};

//--- Emitter ---
datablock ParticleEmitterData(IceShardShineEmitter) {
	className = "ParticleEmitterData";
	ejectionPeriodMS = "275";
	periodVarianceMS = "274";
	ejectionVelocity = "3.92157";
	velocityVariance = "2.44098";
	ejectionOffset = "0";
	thetaMin = "0";
	thetaMax = "180";
	phiReferenceVel = "0";
	phiVariance = "360";
	overrideAdvance = "0";
	orientParticles = "0";
	orientOnVelocity = "1";
	particles = "IceShardShineParticle";
	lifetimeMS = "0";
	lifetimeVarianceMS = "0";
	useEmitterSizes = "0";
	useEmitterColors = "0";
};
