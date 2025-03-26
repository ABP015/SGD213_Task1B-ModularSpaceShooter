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
        bulletOffset = GetComponent<Renderer>().bounds.size.y / 2 // Half of our size
            + bullet.GetComponent<Renderer>().bounds.size.y / 2; // Plus half of the bullet size
    }

    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetButton("Fire1"))
        {
           float CurrentTime = Time.time;

             Have a delay so we don't shoot too many bullets
            if (CurrentTime - lastFiredTime > fireDelay)
            {
                Vector2 spawnPosition = new Vector2(transform.position.x, transform.position.y + bulletOffset);

                Instantiate(bullet, spawnPosition, transform.rotation);

                lastFiredTime = CurrentTime;
            }

            print("Shoot!");
        }*/
    }

    public void Shoot()
    {
        float CurrentTime = Time.time;

        // Have a delay so we don't shoot too many bullets
        if (CurrentTime - lastFiredTime > fireDelay)
        {
            for(float i = -0.5f; i < 1f; i+=0.5f)
            {

                Vector2 spawnPosition = new Vector2(transform.position.x + i, transform.position.y + bulletOffset);

                Instantiate(bullet, spawnPosition, transform.rotation);
            }


            lastFiredTime = CurrentTime;
        }
    }

    /// <summary>
    /// SampleMethod is a sample of how to use abstraction by
    /// specification. It converts a provided integer to a float.
    /// </summary>
    /// <param name="number">any integer</param>
    /// <returns>the number parameter as a float</returns>
    public float SampleMethod(int number) {
        return number;
    }

}
