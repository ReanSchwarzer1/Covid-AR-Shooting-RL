<!DOCTYPE html>
<html>
<body>
<h1 align="center"> Covid-AR-Shooting-RL   (Anti viRL) </h1> <img src="https://github.com/ReanSchwarzer1/Covid-AR-Shooting-RL/blob/main/Images/antiviRL.png" width="300" height="300" align="right" align="top"> 



<h2 align="center"> This project was made in purpose for the Covid-19 Gameathon organized by Angelhack. </h2>  
The repository contains both the PC and the android AR build.
<li>The PC build can be found inside the Build folder.<br></li>
<li>The .apk file for the AR build can be found inside the Build_Android_APK.rar file which in turn is inside the Build_Android_APK folder.<br></li>
<li>The .apk file for the AR build can also be found in the github releases page related to the repository.<br></li>

<h2 align="center"> The Problem Statement </h2>  
In an attempt to fight the virus, this hackathon calls upon developers to create innovative games that address issues faced by people during the pandemic. We are supposed to design a game that will help bring about awareness about the on going pandemic.

<h2 align="center"> Solution </h2>  
Our game takes the essentials of hygiene practices such as frequent sanitizing, social distancing, protecting oneself with a mask etc. into a fun and exciting PC and mobile FPS, surviving with the help of others (yes, it is a multiplayer through and through, without the support for others, the game will end a little too quick) and fending against the swarms of COVID virus cells and each other.

<h2 align="center"> Game Concept </h2>  
The game includes:
<li>Pseudo 2nd person perspective gameplay<br></li>
<li>RL trained enemy virus cells that reduce health of player whilst in proximity<br></li>
<li>Photon API powered multiplayer features<br></li>
<li>Oh yeah, there is an AR version as well<br></li>

<h2 align="center"> Tech Stack </h2>  

Purpose | Tool
------- | -------
Character and Enemy Movement | Unity 2020.4 LTS
Enemy Training  | Unity ML Agents
Enemy, Character and interactable models |  Blender
Multiplayer Integration | Photon API (PUN 2)
AR Integration | Unity Engine x AR Foundation
UI Implementation |  Unity UI x Affinity Designer

<h2 align="center"> Game Design </h2>  
<li>The player is equipped with a sanitizer gun which is used to shoot the virus particles.<br></li>
<li>If the player comes in contact with a particle, it will respawn. <br></li>
<li>Going too close to the particle  reduces players health. <br></li>
<li>Shooting other players with sanitizer results in the increase of health but approaching another player results in the violation of social distance. <br></li>
<li>Masks are present and collecting them increases health of the player. <br></li>
<li>The Reinforced Learned COVID particles have a win/lose reward state which makes the floor red in the player infected state and green if the player successfully evades the particles. <br></li>
<li>As a survivalistic aspect, only the other players can view your player’s health and vice versa that enables them to help each other to fend off against the onslaught of COVID virus cells. <br></li>


<h2 align="center"> Platforms and features </h2>  
<li>Microsoft Windows<br></li>
<li>Android 7.0 and above (ARCore supported devices only)<br></li>


<h2 align="center"> Working Demo </h2>  
<li>Link to gameplay video: https://youtu.be/7yl24mxf_io <br></li>
<li>Link to training demo: https://youtu.be/OmE1qjR9-T0 <br></li>


![Demo1](https://github.com/tamizhis5n/ARchitech-real-estate-AR-solution/blob/master/Images/demo1.gif "Demo1")
![Demo2](https://github.com/tamizhis5n/ARchitech-real-estate-AR-solution/blob/master/Images/demo2.gif "Demo2")


<h2 align="center"> Instructions </h2>  
<li>Download and install the .apk file to run on an ARCore supported android device.<br></li>
<li>For PC, just click on the .exe file inside build.<br></li>

</body>
</html>








