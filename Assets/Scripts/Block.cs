using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collisionInfo) {
        // TODO: eğer blocklar yıkılıp tekrar oluşturuluyorsa, bir ObjectPool'a atılabilir destroy etmek yerine.
        // Destroy the whole Block
        Destroy(gameObject);
    }
}
