# Final Project for the Game Engine 1 course - Santa's Elves
Dive into Christmas by enjoying this cozy narrative game, where you are an elf and you must finish making the last toy that will go into Santa's present bag and will be delivered to children. But before you can complete your toy, you must run a few errands given to you by Santa and the other elves. 

## Game Overview
The game was made in first-person mode, in Unity 3D, in collaboration with [noemiealexia](https://github.com/noemiealexia). The character can move around the toy factory, which consists of 5 rooms, and can interact with other characters and objects by pressing **E**. Some dialogues will be repeated until the you complete a certain action, so you must make sure to talk with everyone again after doing an action (taking an object, completing a task, discovering a secret room). There will be numbers scattered across the rooms, so you will have to use them to figure out the code for the numpads.

## Game Controls
Press E to talk, to interact with objects or to skip the dialogue  
Press ESC (Escape) to pause the game

## Features
* Dialogue system based on dependencies (new dialogues for each character after you complete certain actions)
* Numpad (used to open doors)
* Particle system for the visual effects of the Christmas tree
* Ability to pick up objects

## Credits for the assets
https://assetstore.unity.com/packages/3d/props/free-christmas-assets-low-poly-13102
https://assetstore.unity.com/packages/3d/props/interior/christmas-gifts-52190
https://assetstore.unity.com/packages/3d/props/interior/christmas-toys-106607
https://assetstore.unity.com/packages/3d/props/interior/office-pack-free-258600
https://assetstore.unity.com/packages/3d/props/food/allsorts-candy-12512
https://assetstore.unity.com/packages/3d/props/industrial/low-poly-factory-machine-pack-demo-272637
https://assetstore.unity.com/packages/3d/props/industrial/industrial-models-171071
https://assetstore.unity.com/packages/3d/props/3d-cartoon-cute-safe-pack-297716
https://assetstore.unity.com/packages/3d/props/tools/double-open-end-wrench-170088
https://assetstore.unity.com/packages/3d/props/electronics/keypad-free-262151
https://www.patreon.com/posts/32030551
https://www.patreon.com/posts/94014721
https://assetstore.unity.com/packages/3d/props/retro-psx-horror-puzzle-item-pack-icon-lowpoly-250188
https://sketchfab.com/3d-models/lamps-5287304dab85446eaa8c05c14907be49

## Sounds taken from Pixabay
https://pixabay.com/sound-effects/search/footsteps/
https://pixabay.com/sound-effects/search/door/
https://pixabay.com/music/search/christmas%20background%20music/
https://pixabay.com/sound-effects/search/magic%20sound/
https://pixabay.com/sound-effects/search/positive%20pop/
https://pixabay.com/sound-effects/search/xylophone/

## Steps to run the game
1. Clone the repository
2. Nagivate to the project folder
3. Nagivate to the MainMenu scene in _Assets_ > _Scenes_ > _GameMainMenu.unity_

## Bugs to fix
* If we interact with the wrong person while holding an object in our hands, the object will disappear. However, if we complete some actions in the wrong order (for instance, if we take the Christmas ball before talking to Santa), the object that we are holding will never disappear.  
* Sometimes, we cannot interact with a character by pressing E, because we need to be facing the character in a specific direction for it to work.  
* Game ending timing: after taking the broken toy, we must immediately go talk to Santa to trigger the game ending at the right moment.

## Future features to add
* Character animations  
* Door animations  
* Being able to put objects down and pick them up again (small inventory system)
