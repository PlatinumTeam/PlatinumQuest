//-----------------------------------------------------------------------------
// defaultProperties.cs
//
// Copyright (c) 2015 The Platinum Team
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

/// Default Marble Physics Constants
/// {
$Physics::DefaultMarble::MaxRollVelocity = 15;
$Physics::DefaultMarble::AngularAcceleration = 75;
$Physics::DefaultMarble::BrakingAcceleration = 30;
$Physics::DefaultMarble::AirAcceleration = 5;
$Physics::DefaultMarble::Gravity = 20;
$Physics::DefaultMarble::StaticFriction = 1.1;
$Physics::DefaultMarble::KineticFriction = 0.7;
$Physics::DefaultMarble::BounceKineticFriction = 0.2;
$Physics::DefaultMarble::MaxDotSlide = 0.5;
$Physics::DefaultMarble::JumpImpulse = 7.5;
$Physics::DefaultMarble::MaxForceRadius = 50;
$Physics::DefaultMarble::MinBounceVel = 0.1;
$Physics::DefaultMarble::BounceRestitution = 0.5;
$Physics::DefaultMarble::Mass = 1;
$Physics::DefaultMarble::PowerUpTime3 = 5000;
$Physics::DefaultMarble::PowerUpTime4 = 5000;
$Physics::DefaultMarble::PowerUpTime5 = 5000;
/// }

/// Mega Marble Physics Constants
/// {
$Physics::MegaMarble::MaxRollVelocity = 12;
$Physics::MegaMarble::AngularAcceleration = 60;
$Physics::MegaMarble::BrakingAcceleration = 25;
$Physics::MegaMarble::AirAcceleration = 5;
$Physics::MegaMarble::Gravity = 22;
$Physics::MegaMarble::StaticFriction = 1.0;
$Physics::MegaMarble::KineticFriction = 0.8;
$Physics::MegaMarble::BounceKineticFriction = 0.3;
$Physics::MegaMarble::MaxDotSlide = 0.3;
$Physics::MegaMarble::JumpImpulse = 7.5;
$Physics::MegaMarble::MaxForceRadius = 75;
$Physics::MegaMarble::MinBounceVel = 0.1;
$Physics::MegaMarble::BounceRestitution = 0.5;
$Physics::MegaMarble::Mass = 1;
$Physics::MegaMarble::PowerUpTime3 = 5000;
$Physics::MegaMarble::PowerUpTime4 = 5000;
$Physics::MegaMarble::PowerUpTime5 = 5000;
/// }

/// {
$Physics::Defaults::CameraDistance = 2.5;
$Physics::Defaults::CameraSpeedMultiplier = 1;
$Physics::Defaults::MovementSpeedMultiplier = 1;
$Physics::Defaults::TimeScale = 1;
$Physics::Defaults::SuperJumpVelocity = 20;
$Physics::Defaults::SuperSpeedVelocity = 25;
$Physics::Defaults::SuperBounceRestitution = 0.9;
$Physics::Defaults::ShockAbsorberRestitution = 0.01;
$Physics::Defaults::HelicopterGravityMultiplier = 0.25;
$Physics::Defaults::HelicopterAirAccelerationMultiplier = 2;
/// }

/// Add each physics attribute that we are concerned about with the marble
/// into an attribute list.
/// {
if (!isObject(MarbleDatablockAttributesArray)) {
	Array(MarbleDatablockAttributesArray);
	MarbleDatablockAttributesArray.addEntry("maxRollVelocity");
	MarbleDatablockAttributesArray.addEntry("angularAcceleration");
	MarbleDatablockAttributesArray.addEntry("brakingAcceleration");
	MarbleDatablockAttributesArray.addEntry("airAcceleration");
	MarbleDatablockAttributesArray.addEntry("gravity");
	MarbleDatablockAttributesArray.addEntry("staticFriction");
	MarbleDatablockAttributesArray.addEntry("kineticFriction");
	MarbleDatablockAttributesArray.addEntry("bounceKineticFriction");
	MarbleDatablockAttributesArray.addEntry("maxDotSlide");
	MarbleDatablockAttributesArray.addEntry("bounceRestitution");
	MarbleDatablockAttributesArray.addEntry("jumpImpulse");
	MarbleDatablockAttributesArray.addEntry("maxForceRadius");
	MarbleDatablockAttributesArray.addEntry("minBounceVel");
	MarbleDatablockAttributesArray.addEntry("mass");
	MarbleDatablockAttributesArray.addEntry("cameraDistance");
	MarbleDatablockAttributesArray.addEntry("powerUpTime[3]");
	MarbleDatablockAttributesArray.addEntry("powerUpTime[4]");
	MarbleDatablockAttributesArray.addEntry("powerUpTime[5]");
}
/// }

/// Also keep some info for all attributes
/// {
if (!isObject(MarbleAttributeInfoArray)) {
	Array(MarbleAttributeInfoArray);
	//                                internal name                             type            variable                                                      display name
	MarbleAttributeInfoArray.addEntry("maxRollVelocity"                     TAB "datablock" TAB "$Physics::##::MaxRollVelocity"                           TAB "Max Roll Velocity");
	MarbleAttributeInfoArray.addEntry("angularAcceleration"                 TAB "datablock" TAB "$Physics::##::AngularAcceleration"                       TAB "Angular Acceleration");
	MarbleAttributeInfoArray.addEntry("brakingAcceleration"                 TAB "datablock" TAB "$Physics::##::BrakingAcceleration"                       TAB "Braking Acceleration");
	MarbleAttributeInfoArray.addEntry("airAcceleration"                     TAB "datablock" TAB "$Physics::##::AirAcceleration"                           TAB "Air Acceleration");
	MarbleAttributeInfoArray.addEntry("gravity"                             TAB "datablock" TAB "$Game::Gravity"                                          TAB "Gravity");
	MarbleAttributeInfoArray.addEntry("staticFriction"                      TAB "datablock" TAB "$Physics::##::StaticFriction"                            TAB "Static Friction");
	MarbleAttributeInfoArray.addEntry("kineticFriction"                     TAB "datablock" TAB "$Physics::##::KineticFriction"                           TAB "Kinetic Friction");
	MarbleAttributeInfoArray.addEntry("bounceKineticFriction"               TAB "datablock" TAB "$Physics::##::BounceKineticFriction"                     TAB "Bounce Kinetic Friction");
	MarbleAttributeInfoArray.addEntry("maxDotSlide"                         TAB "datablock" TAB "$Physics::##::MaxDotSlide"                               TAB "Max Dot Slide");
	MarbleAttributeInfoArray.addEntry("bounceRestitution"                   TAB "datablock" TAB "$Physics::##::BounceRestitution"                         TAB "Bounce Restitution");
	MarbleAttributeInfoArray.addEntry("jumpImpulse"                         TAB "datablock" TAB "$Game::JumpImpulse"                                      TAB "Jump Impulse");
	MarbleAttributeInfoArray.addEntry("maxForceRadius"                      TAB "datablock" TAB "$Physics::##::MaxForceRadius"                            TAB "Max Force Radius");
	MarbleAttributeInfoArray.addEntry("minBounceVel"                        TAB "datablock" TAB "$Physics::##::MinBounceVel"                              TAB "Minimum Bounce Velocity");
	MarbleAttributeInfoArray.addEntry("mass"                                TAB "datablock" TAB "$Physics::##::Mass"                                      TAB "Mass");
	MarbleAttributeInfoArray.addEntry("powerUpTime[3]"                      TAB "datablock" TAB "$Physics::##::PowerUpTime3"                              TAB "Super Bounce Duration");
	MarbleAttributeInfoArray.addEntry("powerUpTime[4]"                      TAB "datablock" TAB "$Physics::##::PowerUpTime4"                              TAB "Shock Absorber Duration");
	MarbleAttributeInfoArray.addEntry("powerUpTime[5]"                      TAB "datablock" TAB "$Physics::##::PowerUpTime5"                              TAB "Helicopter Duration");
	MarbleAttributeInfoArray.addEntry("cameraSpeedMultiplier"               TAB "global"    TAB "$Physics::Defaults::CameraSpeedMultiplier"               TAB "Camera Speed Multiplier");
	MarbleAttributeInfoArray.addEntry("movementSpeedMultiplier"             TAB "global"    TAB "$Physics::Defaults::MovementSpeedMultiplier"             TAB "Movement Speed Multiplier");
	MarbleAttributeInfoArray.addEntry("timeScale"                           TAB "global"    TAB "$Physics::Defaults::TimeScale"                           TAB "Time Scale");
	MarbleAttributeInfoArray.addEntry("superJumpVelocity"                   TAB "global"    TAB "$Physics::Defaults::SuperJumpVelocity"                   TAB "Super Jump Velocity");
	MarbleAttributeInfoArray.addEntry("superSpeedVelocity"                  TAB "global"    TAB "$Physics::Defaults::SuperSpeedVelocity"                  TAB "Super Speed Velocity");
	MarbleAttributeInfoArray.addEntry("superBounceRestitution"              TAB "global"    TAB "$Physics::Defaults::SuperBounceRestitution"              TAB "Super Bounce Restitution");
	MarbleAttributeInfoArray.addEntry("shockAbsorberRestitution"            TAB "global"    TAB "$Physics::Defaults::ShockAbsorberRestitution"            TAB "Shock Absorber Restitution");
	MarbleAttributeInfoArray.addEntry("helicopterGravityMultiplier"         TAB "global"    TAB "$Physics::Defaults::HelicopterGravityMultiplier"         TAB "Gyrocopter Gravity Multiplier");
	MarbleAttributeInfoArray.addEntry("helicopterAirAccelerationMultiplier" TAB "global"    TAB "$Physics::Defaults::HelicopterAirAccelerationMultiplier" TAB "Gyrocopter Air Acceleration Multiplier");
}
/// }