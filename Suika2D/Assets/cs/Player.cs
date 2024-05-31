using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxX;
    public float minX;
    public float speed;

    void Update()
    {
        //ad movement
        if(transform.position.x < maxX)
        {
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += new Vector3(1, 0, 0) * Time.deltaTime * speed;
            }
        }
        if(transform.position.x > minX)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * speed;
            }
        }
    }
}
