using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Ball : MonoBehaviour
{
    // Movement Speed
    public float speed = 100.0f;
    private Rigidbody2D _rigidbody;
    // Start is called before the first frame update
    [SerializeField] private SpriteRenderer ballSpriteRenderer;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();   //değişken cachelendi memoryde duruyor
        _rigidbody.velocity = Vector2.up * speed;
        ballSpriteRenderer = GetComponent<SpriteRenderer>();
    }
    

    float hitFactor(Vector2 ballPos, Vector2 racketPos,
                float racketWidth) {
    // ascii art:
    //
    // 1  -0.5  0  0.5   1  <- x value
    // ===================  <- racket
    //
    return (ballPos.x - racketPos.x) / racketWidth;
}

    void OnCollisionEnter2D(Collision2D col) {

    ballSpriteRenderer.DOColor(Color.red, 0f);
    ballSpriteRenderer.DOColor(Color.white, 1f);

    // Hit the Racket?
    if (col.gameObject.name == "racket") {
        SoundManagerScript.PlaySound("ball_racket");
        // Calculate hit Factor
        float x=hitFactor(transform.position,
                          col.transform.position,
                          col.collider.bounds.size.x);

        // Calculate direction, set length to 1
        Vector2 dir = new Vector2(x, 1).normalized;

        // Set Velocity with dir * speed
        GetComponent<Rigidbody2D>().velocity = dir * speed;
    }
    if(col.gameObject.name == "block_blue(Clone)" || col.gameObject.name == "block_blue"){
        SoundManagerScript.PlaySound("ball_block");
    }
    if(col.gameObject.name == "border_top" || col.gameObject.name == "border_left" || col.gameObject.name == "border_right"){
        SoundManagerScript.PlaySound("ball_wall");
    }
}

}
