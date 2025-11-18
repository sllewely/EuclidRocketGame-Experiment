# Stitching together different cameras to create the appearance of great distance, with tiny objects

In Unity 6

<img width="354" height="544" alt="image" src="https://github.com/user-attachments/assets/c85d32f8-219d-49d0-ad8f-d2e7e19ea2b1" />

This demo has three cameras for the near (cellphone), middle (area the player can walk around), and far distance (objects appearing huge in the distance, but represented with small models).


## top world

The player lives in topworld.  This represents the middle distance

<img width="1073" height="492" alt="image" src="https://github.com/user-attachments/assets/5333285f-b9ce-4702-85cc-37697306f40d" />

The character has a movement script and player camera attached to it.

- Attach the underworld camera's script, so the underworld camera can be moved/rotated based on the player character
- set themain world to the layer "top layer"
- set the culling mask of the camera to top layer only
- set the renderer type of the camera to overlay

<img width="439" height="765" alt="image" src="https://github.com/user-attachments/assets/fc13bbee-a2bd-4883-8e2a-2bcf910426a9" />



## the underworld

This is our representation of great scale -- towering buildings in the distance.  But it's built with a tiny model scaled down at a factor of .01f.

This plane is physically 100 units below the plane with the player character.

<img width="1076" height="494" alt="image" src="https://github.com/user-attachments/assets/0f0f3792-129f-413a-8f5c-f22df5d8b0ae" />

The underworld camera has a script which rotates following the player character's camera.  It also translates following the player camera, but scaling down at the same .01f factor.

- set everything in the underworld to the underworld layer
- Set the Culling mask to underworld only
- this camera is the base layer
- add the other two cameras in the Stack section.  These other cameras are Overlay.
- Set the 

<img width="433" height="622" alt="image" src="https://github.com/user-attachments/assets/01a54f83-42c7-4953-bac2-c3960c7d8324" />


## cellphone near distance

other demos use guns :)  This layer renders just the near distance of the cellphone.  If you would clip through some object like a wall, the cellphone is still rendered first

- set the cellphone to the cellphone layer, and the camera's culling mask to only cellphone
- this camera is an overlay.  both it and the cellphone are attached to the player character.
- Set the clipping planes Near distance in the camera > projection to 0.01

<img width="439" height="750" alt="image" src="https://github.com/user-attachments/assets/a26c6e7c-2345-41f0-9a78-818b17583762" />

