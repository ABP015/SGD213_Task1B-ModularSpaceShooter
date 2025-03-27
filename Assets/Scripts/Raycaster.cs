using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position + Vector3.up * 0.5f, Vector2.up, 5);
        if (hit)
        {
            print(hit.collider.name);
        }
    }
}
