using UnityEngine;
using UnityEngine.Events;

public class MusicManager : MonoBehaviour
{
    [SerializeField]
    AK.Wwise.Event musicEvent;

    [SerializeField]
    AK.Wwise.State musicIdleState;

    [SerializeField]
    AK.Wwise.State musicPickupState;

    [SerializeField]
    AK.Wwise.State musicWinState;

    [SerializeField]
    AK.Wwise.Trigger musicPickupStingerTrigger;

    [SerializeField]
    AK.Wwise.CallbackFlags musicCallbackFlags; // Callback flags for music

    [SerializeField]
    UnityEvent musicBarCallbackEvent; // Event that gets invoked when a bar is reached

    [SerializeField]
    UnityEvent musicBeatCallbackEvent; // Event that gets invoked when a beat is reached

    [SerializeField]
    float pickupTimeIncrementAmount = 6f;

    bool isInPickupState = false;
    float pickupTimeRemaining = 0f;
    bool didWin = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        musicEvent.Post(this.gameObject, musicCallbackFlags, MusicSyncCallback);
        ToIdleState();
    }

    // Update is called once per frame
    void Update()
    {
        // Reset from pickup back to idle after pickup time has elapsed
        if (isInPickupState && !didWin)
        {
            if (pickupTimeRemaining <= 0f) // The entirety of the pickup time has elapsed
            {
                // Set music back to idle state
                ToIdleState();

                // Reset book-keeping
                ResetPickupBookkeeping();
            }
            else // Pickup time has not fully elapsed
            {
                // Decrement pickup time remaining
                pickupTimeRemaining -= Time.deltaTime;
            }
        }
    }

    // Reset book-keeping for pickup state tracking
    void ResetPickupBookkeeping()
    {
        isInPickupState = false;
        pickupTimeRemaining = 0f;
    }

    // Transition to idle state
    public void ToIdleState()
    {
        if (!didWin) // Only transition if we haven't already won
        {
            musicIdleState.SetValue(); // Set the Wwise state

            ResetPickupBookkeeping(); // Reset pickup book-keeping
        }
    }

    // Transition to pickup state
    public void ToPickupState()
    {
        musicPickupStingerTrigger.Post(this.gameObject); // Always play stinger

        if (!didWin) // Only transition if we haven't already won
        {
            musicPickupState.SetValue(); // Set the Wwise state

            // Set pickup book-keeping
            isInPickupState = true;
            pickupTimeRemaining = pickupTimeIncrementAmount;
        }
    }

    // Transition to win state
    public void ToWinState()
    {
        musicWinState.SetValue(); // Set the Wwise state

        didWin = true; // Update win flag
        ResetPickupBookkeeping(); // Reset pickup book-keeping
    }

    // Music callback handler
    public void MusicSyncCallback(object inCookie, AkCallbackType inType, object inInfo)
    {
        // Get the callback type
        AkMusicSyncCallbackInfo callbackInfo = (AkMusicSyncCallbackInfo)inInfo;
        AkCallbackType callbackType = callbackInfo.musicSyncType;

        // Invoke events based on callback type -- only bar and beat are handled
        switch (callbackType)
        {
            case AkCallbackType.AK_MusicSyncBar:
                {
                    Debug.Log("Music callback: Bar reached");
                    musicBarCallbackEvent.Invoke();
                }
                break;

            case AkCallbackType.AK_MusicSyncBeat:
                {
                    Debug.Log("Music callback: Beat reached");
                    musicBeatCallbackEvent.Invoke();
                }
                break;

            default:
                { }
                break;
        }
    }
}
