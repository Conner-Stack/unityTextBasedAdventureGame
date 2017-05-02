using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class GameBehavior : MonoBehaviour {
    //serializes everything below it for use in Unity
    [SerializeField]
    //will hold all the GameObjects in a 2D list
    List<GameObject>[,] grid;
    //a public GameObject class that will contain the prefab of my cube
    //will be stored in the list on each instantiation
    public GameObject boxPrefab;
    //an integer for the width, or "rows" of the grid. (x dimension)
    private int width = 10;
    //an integer for the height, or "columns" of the grid (y dimension)
    private int height = 10;
    //creating a function to create a grid, will be used in the 
    //built-in Start() function to generate
    void CreateGrid()
    {
       
        //supposed to extantiate the first game object in each row of the graph
        //will use this for the x transform
        for (int x = 0; x < width; x++)
        {
            //basically for ever GameObject extantiated per iteration of x
            //loops through y instantiating objects as columns
            //will use this as the y transform
            for (int z = 0; z < height; z++)
            {
                //should Instantiate a game object at every iteration of y
                //per iteration of x, not sure how to make this happen with a list
                //also, I haven't found an example of this line, not sure if
                //I should add <gameObject> right after instantiate
                GameObject boxClone = Instantiate(boxPrefab);
                //what this does is take every instantiation of the boxClone gameObject
                //one at a time and sets their position relative to the parent object
                //which should evenly space them out in width and depth
                boxClone.transform.position = new Vector3(boxClone.transform.position.x + x,
                                                           boxClone.transform.position.y,
                                                           boxClone.transform.position.z + z);
                //at the end of the iteration, takes the value of x and z and uses that spot in
                //our list to put that specific instantiation of the grid in it
                
                grid[x, z].Add(boxClone);
                
            }
           
        }
    }
    // Use this for initialization
    void Start () {
        //should create the grid upon start of the application
        CreateGrid();
    }
    // Update is called once per frame
    void Update()
    {
    }
}
