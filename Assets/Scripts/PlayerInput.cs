using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    private Movement movement;
    private IWeapon shooting;

    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponent<Movement>();
        shooting = GetComponent<IWeapon>();
    }

    // Update is called once per frame
    void Update()
    {
        // controls the player movement
        float input = Input.GetAxis("Horizontal");

        movement.Move(Vector2.right * input);

        // fires bullet when button bound to "fire1" is pressed
        if (Input.GetButton("Fire1"))
            if (shooting != null)
            {
                shooting.Shoot();
            }
            else
            {
                Debug.Log("Attach the shooting script!");
            }
    }
}
