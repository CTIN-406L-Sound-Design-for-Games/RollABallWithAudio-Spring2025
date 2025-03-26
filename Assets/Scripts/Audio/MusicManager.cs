using UnityEngine;

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
    float pickupTimeIncrementAmount = 6f;

    bool isInPickupState = false;
    float pickupTimeRemaining = 0f;
    bool didWin = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        musicEvent.Post(this.gameObject);
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

    void ResetPickupBookkeeping()
    {
        isInPickupState = false;
        pickupTimeRemaining = 0f;
    }

    public void ToIdleState()
    {
        if (didWin)
        {
            return;
        }

        musicIdleState.SetValue();

        ResetPickupBookkeeping();
    }

    public void ToPickupState()
    {
        if (didWin)
        {
            return;
        }

        musicPickupState.SetValue();
        
        isInPickupState = true;
        pickupTimeRemaining = pickupTimeIncrementAmount;
    }

    public void ToWinState()
    {
        musicWinState.SetValue();

        didWin = true;
        ResetPickupBookkeeping();
    }
}
