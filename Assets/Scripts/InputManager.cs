using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
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
        float input = Input.GetAxis("Horizontal");

        movement.Move(Vector2.right * input);

        if (Input.GetKeyUp(KeyCode.Space))
        {
            shooting.Shoot();
        }
    }
}
