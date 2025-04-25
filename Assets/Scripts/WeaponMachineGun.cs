using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponMachineGun : WeaponBase 
{

    [SerializeField]
    private ObjectPooler objectPool;


    /// <summary>
    /// Shoot will spawn a new bullet, provided enough time has passed compared to our fireDelay.
    /// </summary>
    public override void Shoot() 
    {
        // get the current time
        float currentTime = Time.time;

        // if enough time has passed since our last shot compared to our fireDelay, spawn our bullet
        if (currentTime - lastFiredTime > fireDelay) 
        {
            // create our bullet
            //GameObject newBullet = Instantiate(bullet, bulletSpawnPoint.position, transform.rotation);
            GameObject newBullet = objectPool.GetObjectFromPool();
            newBullet.SetActive(true);
            newBullet.transform.position = bulletSpawnPoint.position;
            // update our shooting state
            lastFiredTime = currentTime;
        }
    }
}
