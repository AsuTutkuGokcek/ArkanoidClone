using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BlockShrink : MonoBehaviour
{
    public Animation anim;

    void Start(){
        anim = GetComponent<Animation>();
    }
    
    void OnCollisionEnter2D(Collision2D collisionInfo) {
        // TODO: eğer blocklar yıkılıp tekrar oluşturuluyorsa, bir ObjectPool'a atılabilir destroy etmek yerine.
        // Destroy the whole Block
        anim.Play();
        Destroy(gameObject, 1f);
    }
}
