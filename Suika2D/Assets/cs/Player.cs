using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxX;
    public float minX;
    public float speed;
    public GameObject cherry;
    public GameObject orange;
    public GameObject kaki;
    private GameObject currentFruit;

    void Start()
    {
        currentFruit = cherry;
    }

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
        //space key
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //currentFruitのrigidbodyをkinematicをfalseにする
            //currentFruit.GetComponent<Rigidbody2D>().isKinematic = false;
            //currentFruitの位置に生成
            Instantiate(currentFruit, transform.position, transform.rotation);

            //cherry, orange, kakiからランダムで1つ選ぶ
            int random = Random.Range(0, 3);
            if (random == 0)
            {
                // Instantiate(cherry, transform.position, transform.rotation);
                // //rigidbodyをkinematicにする
                // cherry.GetComponent<Rigidbody2D>().isKinematic = true;
                currentFruit = cherry;
            }
            else if (random == 1)
            {
                // Instantiate(orange, transform.position, transform.rotation);
                // orange.GetComponent<Rigidbody2D>().isKinematic = true;
                currentFruit = orange;
            }
            else
            {
                // Instantiate(kaki, transform.position, transform.rotation);
                // kaki.GetComponent<Rigidbody2D>().isKinematic = true;
                currentFruit = kaki;
            }
        }
    }
}
