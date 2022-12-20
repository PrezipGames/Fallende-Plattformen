using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform1 : MonoBehaviour
{
    public Rigidbody2D rb;
    private float fallDelay = 0.4f;
    private float destroyDelay = 3;
    private IEnumerator PlatformFall()
    {
        yield return new WaitForSeconds(fallDelay);
        rb.bodyType = RigidbodyType2D.Dynamic;
        Destroy(gameObject, destroyDelay);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(PlatformFall());
    }
}
