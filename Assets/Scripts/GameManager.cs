using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private GameObject red_block; 
    [SerializeField] public GameObject yellow_block; 
    [SerializeField] public GameObject blue_block;
    int x_yellow;
    int y_yellow;
    int x_blue;
    int y_blue;
    StartBlocksFall startBlocksFall;

    void Awake(){
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        int x_red = (int)red_block.transform.position.x;
        int y_red = (int)red_block.transform.position.y;
        x_yellow = (int)yellow_block.transform.position.x;
        y_yellow = (int)yellow_block.transform.position.y;
        x_blue = (int)blue_block.transform.position.x;
        y_blue = (int)blue_block.transform.position.y;

        for(int i=0; i < 5; i++){
        
            for (int j = 0; j < 13; j++)
            {
                
               Instantiate(red_block, new Vector3(x_red, y_red, 0), Quaternion.identity);
               Instantiate(yellow_block, new Vector3(x_yellow, y_yellow, 0), Quaternion.identity);
               Instantiate(blue_block, new Vector3(x_blue, y_blue, 0), Quaternion.identity);
               x_red += 16;
               x_yellow += 16;
               x_blue += 16;
            }
            y_red -= 8;
            y_yellow += 8;
            y_blue += 8;
            x_red = (int)red_block.transform.position.x;
            x_yellow = (int)yellow_block.transform.position.x;
            x_blue = (int)blue_block.transform.position.x;
        }

        //StartBlocksFall = FindObjectOfType<StartBlocksFall>();
        //StartBlocksFall.Start();
    }

    // Update is called once per frame
    void Update()
    {
        //yellow_block.transform.position = startBlocksFall.pos;
    }
}
