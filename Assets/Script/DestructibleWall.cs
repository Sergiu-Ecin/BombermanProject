using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructibleWall : MonoBehaviour
{
    public int SizeX;
    public int SizeY;
    public int SizeX2;
    public int SizeY2;
    public float spacing = 0.5f;
    public float chanceToSpawn = 0.5f;

    public GameObject destructibleWall;

    void Start()
    {
        InitializeMatrix();
        InitializeMatrix2();
    }

    void InitializeMatrix()
    {
        for (int x = 0; x < SizeX; x++)
        {
            for (int y = 0; y < SizeY; y++)
            {
                GameObject tmp = Instantiate(destructibleWall);
                tmp.transform.SetParent(this.transform);
                tmp.transform.localPosition = new Vector3(x, y, 0);
            }
        }
    }

    void InitializeMatrix2()
    {
        for (int x2 = 0; x2 < SizeX2; x2++)
        {
            for (int y2 = 0; y2 < SizeY2; y2++)
            {
                
                Vector3 pos = new Vector3(y2 * spacing, x2 * spacing,0.1f);

                if (Random.Range(0f, 1f) < chanceToSpawn)
                {
                    Instantiate(destructibleWall, pos, Quaternion.identity, transform.parent);
                }
            }
        }
    }
}
