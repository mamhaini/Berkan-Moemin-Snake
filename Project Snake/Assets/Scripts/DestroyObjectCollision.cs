using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectCollision : MonoBehaviour
{
    // Destroy GameObject on collision
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
