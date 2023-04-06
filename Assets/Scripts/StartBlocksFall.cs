using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBlocksFall : MonoBehaviour
{

    [SerializeField] public GameManager gameManager;
     int y;
     Vector3 pos;
     public float speed = 20f; // The speed at which the object moves
    
    // Start is called before the first frame update
    void Start()
    {
       y = (int)transform.position.y;
       pos = gameManager.yellow_block.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.yellow_block.transform.position.y > 49){
           transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }
}
