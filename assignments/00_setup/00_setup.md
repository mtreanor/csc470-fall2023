

## Unity
Download and install [Unity LTS Release 2022.3.7f1](https://unity.com/releases/editor/qa/lts-releases). You 

![Try this](./install_1.png)
And then make sure to
![Try that](./install_2.png)

<img src="./install_1.png" align="right" width="100" />

After all is done it should work. After all is done it should work. After all is done it should work. After all is done it should work. After all is done it should work. After all is done it should work. After all is done it should work. After all is done it should work. After all is done it should work. After all is done it should work. After all is done it should work. After all is done it should work. After all is done it should work. After all is done it should work. After all is done it should work. After all is done it should work. After all is done it should work. After all is done it should work. After all is done it should work. After all is done it should work. After all is done it should work. After all is done it should work. 

## Steps

## Unity
1. Download and install [Unity Hub](https://unity.com/download).
1. Using Unity Hub, download and install Unity LTS Release 2022.3.7f1. **Make 100% certain you are downloading that exact version!**
    - When prompted, be sure to include WebGL build support
    - When asked, choose to download and use Visual Studio

## Github
1. Go to [github.com](https://github.com/) and create an account
1. Add your Github username to the Google Sheet linked on the course [Canvas](https://canvas.american.edu) page.
1. Download and install [Github Desktop](https://desktop.github.com/)
1. Log into Github desktop

## Create your repository for the class
1. Open Github desktop and log in (you may need to go to Preferences->Accounts)
1. Add a repository for the exercise
    - Name as is specified in the assignment (remember, everything is case sensitive)
    - Make sure the repository is marked as "public"
    - For Local Path put it wherever you like to keep your class files on your computer
    - Ignore the other setting options
    - Check "Initialize this repository with a README"
    - Click "Create Repository"
1. Locate the repository folder on your computer, and add two folders to it: 'assignments' and 'releases'
1. Commit your changes to the repository "locally" by typing a brief summary of what you did in the Summary field (e.g. "Created the repository for csc470") and click "Commit to master" (this should be on the bottom left of the window).
1. On the top/middle region of the screen, click "Publish repository"

## Setting up your Github repository for submitting work
- Go to your web browser, log into Github.com, and find the repository you just created and posted (click the repositories tab).
- Click the "Settings" tab (located in the top middle of the window). Then, click the "Pages" button on the left middle of that window. In that window, under the label that says "Branch" there will be a dropdown that reads "None". Select "main" and click the save button.
- NOTE: If you get something that says "Upgrade or make this repository public to enable Pages", this means that you did not uncheck the box that read "keep it private" when you published your repository. To fix this, you will need to click the "General button" (on the left side of the screen), then scroll down to the bottom of the page where it says "Danger Zone" and click the "Change visibility" button. Follow the steps to make your repository "public", and then try this step again.

## Creating a Unity project
1. Using Unity Hub, create a new project
    - Click "New Project"
    - When prompoted, select 3D Core
    - Name your project as is specified in the assignment (remember, everything is case sensitive)
    - Set the project's location to the `assignments` folder within your local repository for this class (i.e. the folder on your computer).
1. For each project, remember to create .gitignore file with the contents located [here](https://raw.githubusercontent.com/github/gitignore/main/Unity.gitignore) and to place the file in the root directory of the Unity project.
    - Remember to save the file as exactly ".gitignore" (i.e. no file extension such as .txt or .md).
    - You will need to do this for every Unity project! Tons of the errors I encounter are because students forget to do this.
1. Remember to switch your build settings to WebGL.
1. You might as well set the aspect ratio for your game to 16:9 now, as well.