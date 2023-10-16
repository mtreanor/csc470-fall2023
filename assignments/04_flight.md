# Assignment 4: 

## Due
Friday October 31st at 12:55pm.

## Description
For this game, your grade depends on your ambition! For a B, you have a choice of either creating a flight simulator, or a platformer, and completing at least two "challenges" (details below).

BUT, if you want an A, you need to make a game where you can do BOTH! For example, when the plane "lands", the player will "hop" out of the plane and have some task to complete (e.g. collecting stuff).

### Flight Simulator
Create a flight simulator where the player must collect something in the air in order to win (e.g. flying through a ring, or collecting coins).

#### Possible Flight Simulator Challenges (choose 2)
- Have some sort of interesting visual effect happen when you fly through a ring
- Have a fuel meter that decreases as you fly, and have the plane fall to the ground if it gets to zero
- Collect fuel to fill it back up
- Flying enemies that chase you and shoot at the plane

### Platformer
Create a third person 3d platformer where the player must collect something in order to win (e.g. coins), or avoid enemies to stay alive.

#### Possible Platformer Challenges (choose 2)
- Make it so you need to collect a "key" in order to unlock a door to win the game
- Have collectable ammunition and some sort of projectile
- Implement cool jumps (e.g. double jump, wall jump, rocket packs)
- Have enemies that you must stomp on to defeat them
- Make "houses" that you can go in using ProBuilder

## Graduate Student Assignment
You need to do both the flight and platformer with at least 2 challenges each.

## Turning in your assignment
You will be turning in your assignment by pushing both your Unity project to your Github as well as a WebGL build of your game.

Before you push anything to Github, BE EXTRA REALLY SUPER CERTAIN THAT YOUR GITIGNORE FILE IS PLACED AT THE ROOT OF YOUR UNITY PROJECT FOLDER (you need to do this every time you create a new Unity project).

### Building your game for the Web
- In Unity, open the Build Settings (File > Build Settings...)
- Click the Add Open Scenes button
- Select "WebGL" and then click the "Switch Platform" button
Remember to modify your player settings (**remember to disable compression in the Publishing settings** - this is described in more detail on the setup page).
- Click the "Build" button
- When it asks you where you want to put your build, create a folder titled "04_flight" in your "games" folder located in your main repository for the class (csc470-fall2023). It will take several minutes to build your game, and when it is complete you should commit and push your build. After five or so minutes it should be playable at: http://YOUR_GITHUB_USERNAME.github.io/csc470-fall2023/games/04_flight
- If it doesn't work, you may need to take a closer look at the setup instructions.