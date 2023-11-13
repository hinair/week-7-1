# Practical 7.1: Sound in Unity

In the last few weeks, you implemented the collision detection and some animation for a short scene from an adventure game. In this practical, you are going to further extend this scene by adding sound.

By the end of this practical you will be able to:

- Play a sound in response to user input
- Play a sound in response to colliders being hit
-	Use 3D sound to vary the volume of sounds depending on their distance from a listener

To get started, open up your adventure game from last week. Before you begin the tasks, remember that you will need to create an Audio Listener before any sounds can be heard in the scene.

The required sound files for the practical are provided on this repository. For this practical, you can just download the repository as a zip file. Click "Code" and then "Download ZIP". 

## Task 0: Disable 3d character
Add a standard assets FPS controller and disable your Mixamo character for now. It will make things slightly easier as some collisions and the crosshair object do not work correctly with a 3rd person camera! 

## Task 1: Empty Gun Sound Effect
The first problem that the player faces when they enter the scene is that they have no ammunition for their gun. To inform the player of this, and encourage them to go looking for some ammo, edit your shooting script to play the following sound when the player tries to fire their gun when they don’t have any ammo: t1_noammo.mp3 

## Task 2: Door Opening Sound
The user must enter the small hut to get some ammo. In the last practical, you created a script that opened the hut door when the user hits a trigger collider surrounding it. Extend this script so that the following door opening sound is played when the door opens: t2_dooropen.mp3 

## Task 3: Radio Sound
Last week, you might have noticed that there was a radio on the table in the small hut. This radio has an important purpose in the game. It plays a mayday radio message, which informs the player about an imminent plane crash that will play an important role in the next stages of the story. In this task, you should edit the ‘Radio’ game object such that it plays the following sound: t3_radiomayday.mp3 

You should configure the radio’s Audio Source to use 3D sound, so that:
- The radio sound can only be heard within, and in very close proximity to, the hut
- The sound of the radio increases in loudness as the player moves closer to it

## Task 4: Ammo Pickup Sound
When the player picks up the ammo in the hut, a sound should be made to indicate that their gun has been reloaded. In this task you should, find an appropriate gun reload sound on the web, and play it when the player picks up the ammo box. The following site is a good source of free sound clips for use in your interactive environments: http://soundbible.com/ 

## Task 5: Ambient Wind Noise
As the player climbs into the mountains, an ambient wind sound should be heard. This sound should increase in volume as the player climbs higher up the path. The sound should be at full volume when the player crosses the bridge, to indicate that there is a strong wind blowing down the valley, making the crossing dangerous. You should use the wind sound for this task: t5_wind.mp3 

## Task 6: Gun Shot Sound Effect
Once the user has ammo in their gun, they are able to fire it and open the bridge. Edit your shooting script so that the gun plays the following sound effect when the user has ammo and fires the gun: t6_gunshot.mp3 

When writing this script, you will have to set your audio source to play one of two different sounds depending on whether the gun is loaded or not (i.e. whether ammo has been picked up yet). To do this you will need to set the audio source’s ‘clip’ parameter to the desired AudioClip from within code. Take a look at [this script reference page](https://docs.unity3d.com/2018.4/Documentation/ScriptReference/AudioSource-clip.html) to see how to do this.

## Task 7: Bridge Opening Sound
Complete today’s practical by finding an appropriate sound effect from the Internet to play when the bridge opens. You may find that you need to edit the sound effect you’ve found (e.g. using Audition) to make it the correct length, to match the time taken for the bridge to open.

## Optional Extensions

- Edit your shooting script to that a shotgun cocking/reloading sound is heard after each gunshot. When writing this script, you may need to use the WaitForSeconds object shown in [this script example](https://docs.unity3d.com/2018.4/Documentation/ScriptReference/AudioSource-clip.html). You may also consider adding code to prevent the user from firing while reloading is in progress.
- Record a spoken narration track that informs the player what to do at key junctures in the scene. You may wish to speak this track as a third person narrator (as in [the Stanley Parable](https://www.youtube.com/watch?v=w3UxRa_-9UU)).
- Add an airplane model to your scene, which flies over the scene at low level (as if its about to crash) after the player hears the radio message for the first time. Experiment with how the ‘Doppler Level’ parameter changes the way that an Audio Source attached to the moving plane sounds (see more information [here](https://en.wikipedia.org/wiki/Doppler_effect)).
- Experiment with using the Audio Mixer to set the levels of different Audio Sources in your scene (see [this tutorial](https://unity3d.com/learn/tutorials/modules/beginner/5-pre-order-beta/audiomixer-and-audiomixer-groups) from the Unity Learn webpage).




