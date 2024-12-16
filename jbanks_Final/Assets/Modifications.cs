/*
Modifications
1 - I made the color black, the intensity 3, and checked the draw halo box (I did this because I had a idea for making fog with lights, which is why there are multiple lights.  I described modifications to the original lights here.)

2 - I made fog using multiple lights and the draw halo effect to mimic the appearance of thickening fog. (I also unintentionally made it look like the character was running toward spotlights)

Around this point I changed the camera angle to try and make it look like the player is running toward something

3 - put atmosphere thickness at 0.81, exposure at 0.2, I changed the sky tint to a far more darker grayish blue than before (I messed around with these so much that I'm not sure if it's different from the beginning)

4 - The obstacle has 3 shapes, 
5 - uses game hierarchy (empty game object to group it because weird stuff would happen when I just tried to group shapes under shapes), 
6 - and uses two new textures (I took screenshots of supposedly free images on the internet and made them materials).  
7 - I copied my particle system for the power as a baseline then modified it meaning I changed the start color to red, lowered the speed and length scale, and lowered min and max particle speed.

8 - So the lights I had before on the powerup already had many modifications from the normal Gauntlet runner, due to the GameCritic requirements from the previous assignment.  What I changed here was the range, intensity, shadow type (soft shadow), and pressed the draw halo button.

9 - The variation I made was taller
10- Changed color to light blue because it was the only opposing color to red that I frothed up in my mind.  

For the UI I put in the canvas and chose a random sprite that was already in the engine as the image.  I got the button working, but I couldn't figure out for the life of me how to turn off the canvas to play the game, so the game just plays in the background.

The donut mostly was working, until I added the flying donut script, then it would shoot off away from the game whenever it would start. (I was confused for around an hour trying to figure out what was going on with this)

*/