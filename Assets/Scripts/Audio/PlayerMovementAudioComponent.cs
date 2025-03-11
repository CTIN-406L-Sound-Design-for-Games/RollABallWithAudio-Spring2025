using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

/** Data structure for mapping a footstep material's surface tag to a Wwise switch **/
[System.Serializable]
public class FootstepMaterialMapping
{
    public string surfaceTag;
    public AK.Wwise.Switch wwiseSwitch;
}

/** Component that handles player movement audio **/
public class PlayerMovementAudioComponent : MonoBehaviour
{
    [SerializeField]
    AK.Wwise.Event footstepAudioEvent; // Audio event for footsteps

    [SerializeField]
    FootstepMaterialMapping[] footstepMaterialMappings; // SurfaceTag-to-WwiseSwitch mappings for footsteps

    [SerializeField]
    AK.Wwise.RTPC playerSpeedRtpc; // RTPC for player speed

    Vector3 footstepRaycastStartPositionOffset = Vector3.up * 0.05f; // Footstep ray position offset
    float footstepRaycastDistance = 1f; // How far to cast the footstep ray for
    float animationEventWeightThreshold = 0.5f; // Anim weight threshold below which we don't play footstep audio

    CharacterController characterController; // Cached reference to the player character controller

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        UpdatePlayerSpeed();
    }

    private void UpdatePlayerSpeed()
    {
        if (characterController == null)
        {
            return;
        }

        playerSpeedRtpc.SetGlobalValue(characterController.velocity.magnitude);
    }

    // Play footstep audio from an animation event (used for third-person footsteps)
    public void PlayFootstepAudioFromAnimationEvent(AnimationEvent animationEvent)
    {
        if (animationEvent.animatorClipInfo.weight > animationEventWeightThreshold)
        {
            PlayFootstepAudio();
        }
    }

    // Play footstep audio directly (used for first-person footsteps)
    public void PlayFootstepAudio()
    {
        // Cast a ray from the player position (with upwards offset) directly downwards
        Vector3 startPosition = transform.position + footstepRaycastStartPositionOffset;
        RaycastHit[] hits = Physics.RaycastAll(startPosition, Vector3.down, footstepRaycastDistance);

        // Iterate through the raycast hits to see if we find any objects that match our surface tags
        for (int hitIdx = 0; hitIdx < hits.Length; hitIdx++)
        {
            RaycastHit hit = hits[hitIdx];
            Collider hitCollider = hit.collider;

            // If we find a matching surface, we set the appropriate Wwise switch and break out of the loop
            for (int matIdx = 0; matIdx < footstepMaterialMappings.Length; matIdx++)
            {
                FootstepMaterialMapping materialMapping = footstepMaterialMappings[matIdx];
                if (hitCollider.CompareTag(materialMapping.surfaceTag))
                {
                    materialMapping.wwiseSwitch.SetValue(this.gameObject);
                    Debug.LogFormat("PlayFootstepAudio(): {0}", materialMapping.surfaceTag);

                    break;
                }
            }
        }

        // Finally, we post the footstep event to actually play a footstep sound
        footstepAudioEvent.Post(this.gameObject);
    }
}