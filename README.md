# Roll-A-Ball-With-Audio

Roll-A-Ball, now with sound! For USC course CTIN 406L: Sound Design for Games.

Based on Unity's [Roll-A-Ball tutorial](https://learn.unity.com/project/roll-a-ball), adapting the [completed project files](https://assetstore.unity.com/packages/essentials/tutorial-projects/unity-learn-roll-a-ball-completed-project-files-urp-77198) and adding newly implemented audio.

## Week 9: Dynamically Driven Audio
1. [Download the `week9-dynamically-driven-audio` version of the project](https://github.com/usdivad/CTIN406L_RollABallWithAudio/archive/refs/heads/week9-dynamically-driven-audio.zip)
2. The following may be helpful for **Project 2**:
	- Unity:
	    - Assets/Scripts/Audio/PlayerMovementAudioComponent.cs
	    - Assets/Scripts/Audio/FirstPersonFootstepAudioTrigger.cs
	    - Assets/Scenes/Week9_Footsteps_FirstPerson.unity
	    - Assets/Scenes/Week9_Footsteps_ThirdPerson.unity
	- Wwise:
		- \Actor-Mixer Hierarchy\Default Work Unit\SFX\FLY\FLY_Footstep
		- \Switches\Default Work Unit\SWI_FootstepMaterial

## Week 8: More Ambiences
1. [Download the `week8-more-ambiences` version of the project](https://github.com/usdivad/CTIN406L_RollABallWithAudio/archive/refs/heads/week8-more-ambiences.zip)
2. The following may be helpful reference:
	- Wwise:
		- \Actor-Mixer Hierarchy\Default Work Unit\SFX\AMB\AMB_DogBarks
		- \Actor-Mixer Hierarchy\Default Work Unit\SFX\AMB\AMB_CityForestBlend

## Week 6: Middleware, Ambiences
1. [Download the `week6-middleware-ambiences` version of the project](https://github.com/usdivad/CTIN406L_RollABallWithAudio/archive/refs/heads/week6-middleware-ambiences.zip)
2. The following may be helpful for **Project 1**:
	- Unity:
		- Assets/Scenes/Week6_Part1_Middleware.unity
		- Assets/Scenes/Week6_Part2_Ambiences.unity
		- Assets/Scripts/Audio/DistanceBasedAmbienceZone.cs
		- Assets/Scripts/Audio/TriggerBasedAmbienceZone.cs
	- Wwise:
		- RollABallWithAudio-Spring2025_WwiseProject
			- \Actor-Mixer Hierarchy\Default Work Unit\SFX\AMB

## Week 4: Implementation

### Etude 3: Unity Audio Replacement
1. [Download the `week4-implementation` version of the project](https://github.com/CTIN-406L-Sound-Design-for-Games/RollABallWithAudio-Spring2025/archive/refs/heads/week4-implementation.zip)
2. Open **Assets/Scenes/RollABallWithAudio.unity**
3. **Replace all existing audio** with new sound assets that you create
4. (Optional) **Implement new audio** where there previously was none
	- Some ideas:
		- VO for each pickup that matches the current pickup count
		- Adding background music (BGM)
		- Playing different audio clips based on ball velocity
5. **Create a Windows build**, zip it, and upload the zip using the form provided in class
6. Come to class prepared to share and discuss with everyone!

## Dependencies
- [Unity 6 (6000.0.36f1)](https://unity.com/download)
