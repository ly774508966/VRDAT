# VRDAT
Virtual Reality Development Acceleration Toolkit, a project done at RPI.

### Objective
VRDAT aims to reduce the strain of VR development by recording movement with a VR HMD and playing it back for faster debugging. This reduces the need to put on / take off the HMD every time you want to debug something.

VRDAT was planned to be a full input recording system for the HTC Vive in Unity, meaning any inputs and positions would be recording according to a user-defined timestep, and then played back. Unfortunately, after finishing position + rotation playback, there was a realization that recording precise input on the Vive controller created massive data sets that were terribly large for any accurate timestep. Recording the stae of every possible input at every timestep caused major slowdowns, as well as playback problems. There also was the problem of partial inputs. What if a button has different actions depending on the trigger position? This just added onto the list of additional data we had to record at each timestep.

In conclusion, VRDAT was a decent idea in theory, but not entirely practical in reality. It would be more effecient for developers to create their own proprietary recording system that fits their needs specifically, rather than trying to generalize and consolidate all input recording into one general system.

###Licensing
VRDAT is licensed under the MIT license, as it utilizes other technologies are stipulate similar licensing rights. 

### Tech
Unity 5.6  
-SteamVR Plugin  
-OpenVR  
-NewtonVR  
-OSVR  
-VRTK  
  
