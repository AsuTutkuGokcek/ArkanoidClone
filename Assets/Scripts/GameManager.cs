using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private GameObject red_block; 
    [SerializeField] public GameObject yellow_block; 
    [SerializeField] public GameObject blue_block;
    [SerializeField] public GameObject pink_block;
    [SerializeField] public GameObject green_block;
    int x_red;
    int y_red;
    int x_yellow;
    int y_yellow;
    int x_blue;
    int y_blue;
    int x_pink;
    int y_pink;
    int x_green;
    int y_green;
    StartBlocksFall startBlocksFall;

    void Awake(){
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        x_red = (int)red_block.transform.position.x;
        y_red = (int)red_block.transform.position.y;
        x_yellow = (int)yellow_block.transform.position.x;
        y_yellow = (int)yellow_block.transform.position.y;
        x_blue = (int)blue_block.transform.position.x;
        y_blue = (int)blue_block.transform.position.y;
        x_pink = (int)pink_block.transform.position.x;
        y_pink = (int)pink_block.transform.position.y;
        x_green = (int)green_block.transform.position.x;
        y_green = (int)green_block.transform.position.y;

        for(int i=0; i < 5; i++){
        
            for (int j = 0; j < 13; j++)
            {
                
               Instantiate(red_block, new Vector3(x_red, y_red, 0), Quaternion.identity);
               Instantiate(yellow_block, new Vector3(x_yellow, y_yellow, 0), Quaternion.identity);
               Instantiate(blue_block, new Vector3(x_blue, y_blue, 0), Quaternion.identity);
               Instantiate(pink_block, new Vector3(x_pink, y_pink, 0), Quaternion.identity);
               Instantiate(green_block, new Vector3(x_green, y_green, 0), Quaternion.identity);
               x_red += 16;
               x_yellow += 16;
               x_blue += 16;
               x_pink += 16;
               x_green += 16;
            }
            y_red -= 8;
            y_yellow += 8;
            y_blue += 8;
            y_pink += 8;
            y_green += 8;
            x_red = (int)red_block.transform.position.x;
            x_yellow = (int)yellow_block.transform.position.x;
            x_blue = (int)blue_block.transform.position.x;
            x_pink = (int)pink_block.transform.position.x;
            x_green = (int)green_block.transform.position.x;
        }

    }

    // Update is called once per frame
    void Update()
    {
    }
}
