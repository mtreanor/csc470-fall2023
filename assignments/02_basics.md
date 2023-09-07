# Assignment 2: Basics

## Description
- Create at least 2 **prefabs** that have their origin at their bottom center. This demonstrates that you understand the hierarchy.
- At runtime, generate at least 10 instances of each prefab. See [this example](https://github.com/mtreanor/csc470-fall2023/blob/main/examples/Basics/Assets/WorldGenerator.cs) for help.
    - Place one of types of objects randomly in the scene. 
    - The other should be placed in a deliberate pattern. In other words, a row, or a grid, or a circle, or something else.
- Given some input event (a key press, a mouse click, etc.), some movement should be initiated that interacts with at least one of the prefabs.
    - For example, a cactus with a SphereCollider will start rolling down towards a bunch of generated spiders, and the spiders will fall over or something. 
- It should be relatively easy to achieve the above if you look at the example, so you will also be assessed based on your level of creativity. Try to have fun and do somthing interesting!

## Turning in your assignment
You will be turning in your assignment by pushing both your Unity project to your Github as well as a WebGL build of your game.

Before you do anything, BE EXTRA REALLY SUPER CERTAIN THAT YOUR GITIGNORE FILE IS PLACED AT THE ROOT OF YOUR UNITY PROJECT FOLDER (you need to do this every time you create a new Unity project).

### Building your game for the Web
- In Unity, open the Build Settings (File > Build Settings...)
- Click the Add Open Scenes button
- Select "WebGL" and then click the "Switch Platform" button
Remember to modify your player settings (remember to disable compression in the Publishing settings - this is described in more detail on the setup page).
- Click the "Build" button
- When it asks you where you want to put your build, create a folder titled "02_basics" in your "games" folder located in your main repository for the class (csc470-fall2023). It will take several minutes to build your game, and when it is complete you should commit and push your build. After five or so minutes it should be playable at: http://YOUR_GITHUB_USERNAME.github.io/csc470-fall2023/games/02_basics
- If it doesn't work, you may need to take a closer look at the setup instructions.