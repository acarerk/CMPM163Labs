varying vec3 vUv;
uniform vec3 colorA;
uniform vec3 colorB;
uniform vec3 colorC;
uniform vec3 colorD;


void main() {
  gl_FragColor = vec4(mix(mix(mix( 0.2 * colorA, colorB, (vUv.z - 0.3)),colorC,(vUv.x - 0.3)),colorD,(vUv.y - 0.2)), 1.0);
}
