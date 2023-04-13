using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BlockFade : MonoBehaviour
{
    [SerializeField] private SpriteRenderer fadingSpriteRenderer;

    void Start(){
        fadingSpriteRenderer = GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D collisionInfo) {
        fadingSpriteRenderer.DOFade(0,2);
        StartCoroutine(SelfDestruct());
    }

    IEnumerator SelfDestruct(){
        yield return new WaitForSeconds(2f);
        Destroy (gameObject);
    }
}
