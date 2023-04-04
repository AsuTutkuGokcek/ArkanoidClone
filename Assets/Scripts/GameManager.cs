using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private GameObject block; 

    void Awake(){
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        int x = (int)block.transform.position.x;
        int y = (int)block.transform.position.y;
        for(int i=0; i < 5; i++){
        
            for (int j = 0; j < 13; j++)
            {
                
               Instantiate(block, new Vector3(x, y, 0), Quaternion.identity);
               x += 16;
            }
            y -= 8;
            x = (int)block.transform.position.x;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
