using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFallThenUp : MonoBehaviour
{
 
    [SerializeField] public GameManager gameManager;
    public float speed = 120f; // The speed at which the object moves
    bool touched = false;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(touched==false && gameManager.blue_block.transform.position.y > 35){
           transform.Translate(Vector3.down * speed * Time.deltaTime);
        }else
        {
            touched = true;
        }

        if(touched==true && gameManager.blue_block.transform.position.y < 49){
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
    }
}
