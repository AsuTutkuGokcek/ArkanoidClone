using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockFallDown : MonoBehaviour
{
    private float falldelay = 1f;
    private float destroydelay = 0.05f;

    SpriteRenderer rend;

    [SerializeField] private Rigidbody2D rb;

    void Start(){
        rend = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D collisionInfo) {
        // Destroy the whole Block
        StartCoroutine(Fall());
    }

    private IEnumerator Fall(){
        yield return new WaitForSeconds(falldelay);
        rb.bodyType = RigidbodyType2D.Dynamic;

        for(float f = 1f; f >= -0.05f; f -= 0.05f){
            Color c = rend.material.color;
            c.a = f;
            rend.material.color = c;
            yield return new WaitForSeconds(0.05f);
            
        }
        Destroy(gameObject, destroydelay);

    }
}
