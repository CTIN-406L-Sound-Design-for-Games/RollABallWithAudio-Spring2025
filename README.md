# Roll-A-Ball-With-Audio

Roll-A-Ball, now with sound! For USC course CTIN 406L: Sound Design for Games.

Based on Unity's [Roll-A-Ball tutorial](https://learn.unity.com/project/roll-a-ball), adapting the [completed project files](https://assetstore.unity.com/packages/essentials/tutorial-projects/unity-learn-roll-a-ball-completed-project-files-urp-77198) and adding newly implemented audio.

## Week 12: Music & Gameplay, Effects, Spatial Audio
1. [Download the `week12-music-gameplay-effects-spatial-audio` version of the project](https://github.com/CTIN-406L-Sound-Design-for-Games/RollABallWithAudio-Spring2025/archive/refs/heads/week12-music-gameplay-effects-spatial-audio.zip)
2. The following may be helpful reference:
	- Unity:
		- Assets/Scenes/Week12_MusicGameplay_Effects_SpatialAudio.unity
		- Music & Gameplay:
		    - Assets/Scripts/Audio/MusicManager.cs
    	    - Assets/Scripts/Gameplay/NonPlayerBall.cs
    	- Effects:
		    - Assets/Scripts/Audio/HelmetAudioComponent.cs
		    - Assets/Scripts/Gameplay/Helmet.cs
	- Wwise:
		- Effects:
			- \Effects\Default Work Unit\FX_HelmetDistortion
			- \Master-Mixer Hierarchy\Default Work Unit\Master Audio Bus\SFX
			- \Actor-Mixer Hierarchy\Default Work Unit\SFX\PLR\MVT_BallRolling_LP
		- Spatial Audio:
			- \Master-Mixer Hierarchy\Default Work Unit\Master Audio Bus\RVB

## Week 10: Interactive Music
1. [Download the `week10-interactive-music` version of the project](https://github.com/CTIN-406L-Sound-Design-for-Games/RollABallWithAudio-Spring2025/archive/refs/heads/week10-interactive-music.zip)
2. The following may be helpful for **Project 3**:
	- Unity:
	    - Assets/Scripts/Audio/MusicManager.cs
	    - Assets/Scenes/Week10_Music.unity
	- Wwise:
		- \Interactive Music Hierarchy\Default Work Unit\MUS_BGM
		- \States\Default Work Unit\STA_GameState
		- \Triggers\Default Work Unit\TRG_MusicPickup

## Week 9: Dynamically Driven Audio
1. [Download the `week9-dynamically-driven-audio` version of the project](https://github.com/CTIN-406L-Sound-Design-for-Games/RollABallWithAudio-Spring2025/archive/refs/heads/week9-dynamically-driven-audio.zip)
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
1. [Download the `week8-more-ambiences` version of the project](https://github.com/CTIN-406L-Sound-Design-for-Games/RollABallWithAudio-Spring2025/archive/refs/heads/week8-more-ambiences.zip)
2. The following may be helpful reference:
	- Wwise:
		- \Actor-Mixer Hierarchy\Default Work Unit\SFX\AMB\AMB_DogBarks
		- \Actor-Mixer Hierarchy\Default Work Unit\SFX\AMB\AMB_CityForestBlend

## Week 6: Middleware, Ambiences
1. [Download the `week6-middleware-ambiences` version of the project](https://github.com/CTIN-406L-Sound-Design-for-Games/RollABallWithAudio-Spring2025/archive/refs/heads/week6-middleware-ambiences.zip)
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
