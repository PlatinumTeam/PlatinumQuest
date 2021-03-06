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

varying vec2 uv;
varying vec3 light_vector;
varying vec3 eye_vector;
varying vec3 vert_position;
varying vec3 normal_vector;

uniform sampler2D textureSampler;
uniform sampler2D normalSampler;
#if (QUALITY_LEVEL > 0)
uniform sampler2D specularSampler;
#endif
#if (QUALITY_LEVEL > 1)
uniform samplerCube skyboxSampler;
uniform sampler2D skyFrontSampler;
uniform sampler2D skyBackSampler;
#endif

uniform vec4 ambient_color;
uniform vec3 sun_direction;
uniform vec4 sun_color;
uniform int specular_exponent;
uniform vec3 camera_position;
uniform float reflectivity;
uniform vec2 textureScale;
uniform int time;

// Because radians
#define PI 3.14159265
#define TWO_PI 6.2831853

// How long the reflected sky sphere takes to complete one full rotation
#define ROTATION_TIME 60000

// Color added at the end to lighten the ice
#define ICE_COLOR_ADD vec4(0.2, 0.25, 0.3, 1.0)

void main() {
    // Correct UV based on texture scale
    vec2 scaled_uv = uv * textureScale;

    // Texture values
    vec3 material_color = texture2D(textureSampler, scaled_uv).rgb;
    vec3 normal_color = normalize(texture2D(normalSampler, scaled_uv).rgb * 2.0 - 1.0);

    // Normalize the light vector so we can dot it
    vec3 light_normal = normalize(light_vector);

    // Cosine of the angle from the light to the normal
    float cosTheta = clamp(dot(normal_color, light_normal), 0, 1);

    // Sun color is multiplied by angle for bump mapping, then clamped to [0, 1] so we don't clip
    vec4 effectiveSun = sun_color * cosTheta;

    // Ambient color first
    effectiveSun += ambient_color;

    // Clamp sun so we don't clip
    effectiveSun = vec4(clamp(effectiveSun.r, 0, 1), clamp(effectiveSun.g, 0, 1),
                        clamp(effectiveSun.b, 0, 1), 1);

    // Diffuse color
    gl_FragColor = vec4(material_color * effectiveSun.rgb, 1);

// Only high quality gets reflections.
#if (QUALITY_LEVEL > 1)
    // Worldspace normal taking normal mapping into account
    vec3 normal_model = normalize(reflect(-normal_vector, normal_color));
    // Direction from camera to vertex
    vec3 camera_direction = normalize(vert_position - camera_position);
    // Reflect the camera off the normal so we know where on the skysphere to show
    vec3 camera_reflection = reflect(camera_direction, normal_model);

    // Find UV coordinates of the reflection on the sky sphere
    vec2 skyUV = vec2(0.5 - (atan(camera_reflection.y, camera_reflection.x) / TWO_PI),
                      0.5 - (asin(camera_reflection.z) / PI));

    // Rotate the coordinates so the clouds spin around
    skyUV += vec2((float(time) / ROTATION_TIME), 0);
    // Cloud color from the skysphere
    vec4 reflectionBackColor = texture2D(skyBackSampler, skyUV);
    vec4 reflectionFrontColor = texture2D(skyFrontSampler, skyUV);

    // Let the front color overlay the back
    vec4 reflectionColor = mix(reflectionFrontColor, reflectionBackColor, reflectionBackColor.a);

    // Apply the reflected skysphere color
    gl_FragColor = mix(gl_FragColor, reflectionColor, reflectivity);
#endif

    // Ice is too dark without a little color added, so we adjust it a bit
    gl_FragColor += ICE_COLOR_ADD * cosTheta;

// Low quality does not get specular highlights as it's a more expensive calculation.
#if (QUALITY_LEVEL > 0)
    vec3 specular_color = texture2D(specularSampler, scaled_uv).rgb;

    // Direction of the light reflection
    vec3 light_reflection = reflect(-light_normal, normal_color);

    // Angle from the eye vector and reflect vector
    float cosAlpha = clamp(dot(normalize(eye_vector), light_reflection), 0, 1.0);

    // Specular highlights
    gl_FragColor += vec4(specular_color * sun_color.rgb * pow(cosAlpha, specular_exponent), 1);
#endif
}