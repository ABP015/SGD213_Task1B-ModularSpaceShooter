using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour
{
    // SerializeField exposes this value to the Editor, but not to other Scripts!
    // It is "pseudo public"
    // HorizontalPlayerAcceleration indicates how fast we accelerate Horizontally
    [SerializeField]
    private float horizontalAcceleration = 5000f;

    private Rigidbody2D ourRigidbody;

    // Use this for initialization
    void Start()
    {
        // Get OurRigidbodyComponent once at the start of the game and store a reference to it
        // This means that we don't need to call GetComponent more than once! This makes our game faster. (GetComponent is SLOW)
        ourRigidbody = GetComponent<Rigidbody2D>();
    }
   
    public void HorizontalMovement(float HorizontalInput)
    {
        Vector2 ForceToAdd = Vector2.right * HorizontalInput * horizontalAcceleration * Time.deltaTime;
        ourRigidbody.AddForce(ForceToAdd);
    }
}

