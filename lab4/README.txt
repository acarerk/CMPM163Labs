# CMPM163Labs
##LAB4
Video Link: https://drive.google.com/file/d/1Sv3dN39vzGFjjndpFdIIkvhc0gL8Qh7A/view?usp=sharing

Cube1: Loaded texture 168 into a Mesh Phong Material.
Cube2: Loaded texture 168 and the normal map of that texture into a Mesh Phong Material.
Cube3: Mismatched texture and normal map. Loaded texture 168 and normal map 176 and rendered it using custom shaders.
Cube4: rendered with the new shaders. loaded texture 184 using the custom fragment shader.
Cube5: used texture 176 since it is easy to tile. Multiplied the vUv vector with 2 to reduce the size of the texture on the surface of the cube. Then, I implemented if statements to check what position is being currently rendered. According to which quadrant the vUv value is at, I created a new vector2 called vUv2 (that is a copy of vUv) and offset its values accoridngly before feeding it nto the texture2D() function. For example, when vUv.x > 0.5 and vUv.y < 5, I reduced the vUv2.x value by 1.

24)
a. 8u = x
b. 8b = y
c. gray
