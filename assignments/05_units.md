# Assignment 5: Resource Management and Managing Units

## Due
Tuesday November 21st at 12:55pm.

## Description
For this assignment you will explore using the mouse and user interface elements to make a game. Many genres, such as real time strategy (e.g. StarCraft), simulation (e.g. Cities: Skylines), MOBA (League of Legends), and more use this mode of interaction. While there isn't anywhere near enough time to make a full game those, you do now have the ability to make a small game like them!

One requirement of this game is that it must involve "resources" (e.g. health, happiness, gold, etc.) that are affected through gameplay. Obviously you will need a way to represent that information, and most games do this via 'meters' that are filled to various degrees that show how much of some resource there is. 

Here are some ideas, but feel free to come up with your own:
- Have two types of units, and make it so a unit's happiness meter is lowered when inslulted, and filled when they are complimented. The game is about keeping your team happy and making the other team unhappy.
- Create an object that units can "mine". For example, when a unit is near the gold mine, have a meter fill. When it is full, have the unit be able to "drop off" gold at some home base. When homebase has enough gold, allow the player to place a new building or something.
- Have the player control one unit and have them need to fight off waves of enemies using special attacks that you select via the UI. In this case you would need meters to represent health.
- Have the player be able to place various types of buildings or zones on a grid. Have the placed areas update their stats over time based on the distance from the various other types of placed buildings.

## Graduate Student Assignment
As this is a pretty open ended project, I am not expecting anything specific from graduate students. However, the quality of the game, and the code will be evaluated more critically.

## Turning in your assignment
You will be turning in your assignment by pushing both your Unity project to your Github as well as a WebGL build of your game.

Before you push anything to Github, BE EXTRA REALLY SUPER CERTAIN THAT YOUR GITIGNORE FILE IS PLACED AT THE ROOT OF YOUR UNITY PROJECT FOLDER (you need to do this every time you create a new Unity project).

### Building your game for the Web
- In Unity, open the Build Settings (File > Build Settings...)
- Click the Add Open Scenes button
- Select "WebGL" and then click the "Switch Platform" button
Remember to modify your player settings (**remember to disable compression in the Publishing settings** - this is described in more detail on the setup page).
- Click the "Build" button
- When it asks you where you want to put your build, create a folder titled "05_units" in your "games" folder located in your main repository for the class (csc470-fall2023). It will take several minutes to build your game, and when it is complete you should commit and push your build. After five or so minutes it should be playable at: http://YOUR_GITHUB_USERNAME.github.io/csc470-fall2023/games/05_units
- If it doesn't work, you may need to take a closer look at the setup instructions.