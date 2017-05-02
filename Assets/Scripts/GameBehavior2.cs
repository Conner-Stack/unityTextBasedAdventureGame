using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class GameBehavior2 : MonoBehaviour {
    [SerializeField]
    int width = 10;
    int length = 10;
    GameObject Tile;
    GameObject tilePrefab;
    void CreateGrid()
    {

        for (int x = 0; x < width; x++)
        {
            Tile = Instantiate(tilePrefab) as GameObject;
            for (int z = 0; z < length; z++)
            {
             
            }
            Tile = Instantiate(tilePrefab) as GameObject;
        }
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
