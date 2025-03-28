using UnityEngine;
using System.Collections;

public class TrippleShot : MonoBehaviour, IWeapon 
{
    [SerializeField]
    private GameObject bullet;

    private float lastFiredTime = 0f;

    [SerializeField]
    private float fireDelay = 1f;

    private float bulletOffset = 2f;

    void Start()
    {
        // Do some math to perfectly spawn bullets in front of us
        // Half of our size plus half of the bullet size
        bulletOffset = GetComponent<Renderer>().bounds.size.y / 2 + bullet.GetComponent<Renderer>().bounds.size.y / 2; 
    }

    public void Shoot()
    {
        float CurrentTime = Time.time;

        // Have a delay so we don't shoot too many bullets
        if (CurrentTime - lastFiredTime > fireDelay)
        {
            // changes the spawn location of bullets to avoid overlapping
            for(float i = -0.5f; i < 1f; i+=0.5f)
            {
                Vector2 spawnPosition = new Vector2(transform.position.x + i, transform.position.y + bulletOffset);
                Instantiate(bullet, spawnPosition, transform.rotation);
            }

            lastFiredTime = CurrentTime;
        }
    }
}
