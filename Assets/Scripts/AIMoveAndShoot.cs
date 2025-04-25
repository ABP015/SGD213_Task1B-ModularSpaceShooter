 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMoveAndShoot : MonoBehaviour, IWeapon 
{

    // state
    private Vector2 movementDirection;

    // local references
    private EngineBase movement;
    private WeaponBase weapon;

    void Start() 
    {
        // populate our local references
        movement = GetComponent<EngineBase>();
        weapon = GetComponent<WeaponBase>();

        // get a random direction between South-East and South-West
        float x = Random.Range(-0.5f, 0.5f);
        float y = -0.5f;
        movementDirection = new Vector2(x, y).normalized; // ensure it is normalised
    }

    // Update is called once per frame
    void Update () 
    {
        // move our enemy using the EngineBase
        if (movement != null) 
        {
            movement.Accelerate(movementDirection);
        }

        // shoot if we have a IWeapon component attached
        if (weapon != null) 
        {
            weapon.Shoot();
        }
    }
}
