using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BlockShrink : MonoBehaviour
{

    void Start(){

    }
    
    void OnCollisionEnter2D(Collision2D collisionInfo) {
        transform.DOScale(new Vector3 (0,0,0), 2f);
        StartCoroutine(SelfDestruct());
    }

        IEnumerator SelfDestruct(){
        yield return new WaitForSeconds(2f);
        Destroy (gameObject);
    }
}
