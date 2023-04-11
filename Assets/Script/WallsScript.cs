using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsScript: MonoBehaviour
{ 
    public int SizeX;
    public int SizeY;

    public GameObject Wall;

    // Start is called before the first frame update
    void Start()
    {
        InitializeMatrix();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InitializeMatrix()
    {
        for (int x = 0; x < SizeX; x++)
        {
            for (int y = 0; y < SizeY; y++)
            {
                GameObject tmp = Instantiate(Wall);
                tmp.transform.SetParent(this.transform);
                tmp.transform.localPosition = new Vector3(x, y, 0);
            }
        }
    }
}
