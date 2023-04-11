using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = new Vector3(0, 3.5f, 0);
        Instantiate(player, pos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
