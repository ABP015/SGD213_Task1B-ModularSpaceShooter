using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float acceleration = 75f;

    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector2 direction)
    {
        rb.AddForce(direction * acceleration * Time.deltaTime); 
    }
}
