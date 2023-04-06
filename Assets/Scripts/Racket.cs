using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    // Movement Speed
    public float speed = 150;
    private Rigidbody2D _rigidbody;

    void Start(){
        _rigidbody = GetComponent<Rigidbody2D>();   //değişken cachelendi memoryde duruyor
    }

    void FixedUpdate () {
        // Get Horizontal Input
        float h = Input.GetAxisRaw("Horizontal");

        // Set Velocity (movement direction * speed)
        _rigidbody.velocity = Vector2.right * h * speed;
    }
}
