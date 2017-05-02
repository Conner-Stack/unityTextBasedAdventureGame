using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class GameBehavior : MonoBehaviour {
    List<GameObject>[,] Boxes;
    [SerializeField]
    public GameObject boxPrefab;
    private int width = 10;
    private int height = 10;
    public Rigidbody rgd;
   
    void CreateGrid()
    {
        
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
            Boxes[x,y] = Instantiate<>   
            }
             = Instantiate(boxPrefab) as GameObject;
        }
    }
    // Use this for initialization
    void Start () {
        Boxes = new List<GameObject>();
        Getcompo
    }
	// Update is called once per frame
	void Update () {
         Inst
}
