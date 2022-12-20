using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform2 : MonoBehaviour
{
    public Rigidbody2D rb;
    private float collisionTime;
    private float maxCollisionTime = 0.5f;
    private float destroyDelay = 2;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collisionTime = 0;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        collisionTime += Time.deltaTime;

        if (collisionTime >= maxCollisionTime)
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
            Destroy(gameObject, destroyDelay);
        }
    }
}
