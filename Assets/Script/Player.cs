using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 previousPosition;

    private void Start()
    {
        previousPosition= transform.position;
    }
    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        if (Input.GetKeyDown("up"))
        {
            transform.Translate(0, 0.5f, 0);
        }
        if (Input.GetKeyDown("down"))
        {
            transform.Translate(0, -0.5f, 0);
        }
        if (Input.GetKeyDown("left"))
        {
            transform.Translate(-0.5f, 0, 0);
        }
        if (Input.GetKeyDown("right"))
        {
            transform.Translate(0.5f, 0, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Walls"))
        {
            transform.position= previousPosition;
        } else {
            previousPosition= transform.position;
        }
    }
}
