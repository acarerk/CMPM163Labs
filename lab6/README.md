# Types of lights:

## Point Light: <br/> 

It behaves like a bare lightbulb. It illuminates the scene 
according to its position. Its rotation has no effect. <br/>
## Directional Light: <br/>

It behaves like the sun. It illuminates all object in the scene, 
lighting them based on the direction of the gameobject. Its position in the scene is irrelevant. <br/>
## Spot Light: <br/>

It behaves like a flashlight or headlights on a car. It points in a direciton based 
on the rotation of the gameobject and illuminate all objects in a cone. It illumnates objects 
based on both position and rotation of the gameobject. <br/>
## Area Light: <br/>

It only works while baking a lightmap. It shines in all directions to one side of a rectangular plane. <br/>

![Lights](lights.png)

# Material:

original
![glass](IMG_2572.jpg)
material in unity
![material](glassMaterial.png)

## How I did it: <br/>

I used the Standard(specular) shader and reduced the alpha channel of the albedo color to make it slightly transparent. I used the specular channel to emulate the mostly diffuse nature of the glass. I adjusted the smoothness slider to get the correct reflectivity of the material. <br/>

# Textures: <br/>

Cube on the left: grass texture <br/>
Cube on the right: stone texture <br/>
(I found both of these textures on the unity asset store for free) <br/>

![textures](textures.png)

# Skybox: <br/>
I used a starfield skybox that I got from the unity asset store for free

![skybox](skybox.png)
