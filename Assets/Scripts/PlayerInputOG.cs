using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputOG : MonoBehaviour
{

    private EngineBaseOG movement;
    private IWeapon shooting;
    private WeaponBase weapon;

    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponent<EngineBaseOG>();
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
    /// <summary>
    /// SwapWeapon handles creating a new WeaponBase component based on the given weaponType. This
    /// will popluate the newWeapon's controls and remove the existing weapon ready for usage.
    /// </summary>
    /// <param name="weaponType">The given weaponType to swap our current weapon to, this is an enum in WeaponBase.cs</param>
    public void SwapWeapon(WeaponType weaponType)
    {
        // make a new weapon dependent on the weaponType
        WeaponBase newWeapon = null;
        switch (weaponType)
        {
            case WeaponType.machineGun:
                newWeapon = gameObject.AddComponent<WeaponMachineGun>();
                break;
            case WeaponType.tripleShot:
                newWeapon = gameObject.AddComponent<WeaponTripleShot>();
                break;
        }

        // update the data of our newWeapon with that of our current weapon
        newWeapon.UpdateWeaponControls(weapon);
        // remove the old weapon
        Destroy(weapon);
        // set our current weapon to be the newWeapon
        weapon = newWeapon;
    }
}


