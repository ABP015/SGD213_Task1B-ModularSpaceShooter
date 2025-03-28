using UnityEngine;
using System.Collections;

public class DestroyedOnExit : MonoBehaviour
{
    // Called when the object leaves the viewport
    void OnBecameInvisible()
    {
        // destroys object when it leaves the viewport
        Destroy(gameObject);
    }
}
