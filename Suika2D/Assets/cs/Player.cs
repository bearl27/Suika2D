using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxX;
    public float speed;
    public GameObject[] FruitsList;
    public float plus = 0.2f;
    private float time = 1.0f;
    public AudioClip apperSound;
    public GameObject next;

    const float spaceDelay = 1.0f;

    void Update()
    {
        time -= Time.deltaTime;
        //ad movement
        if(transform.position.x < maxX)
        {
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += new Vector3(1, 0, 0) * Time.deltaTime * speed;
            }
        }
        if(transform.position.x > -maxX)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * speed;
            }
        }
        //space key
        if (time < 0 && Input.GetKeyDown(KeyCode.Space))
        {
            time = spaceDelay;
            transform.position += new Vector3(plus, 0, 0) * Time.deltaTime * speed;
            plus *= -1;
            //currentFruitの位置に生成
            Instantiate(FruitsList[NextFruit.nextFruitID], transform.position, transform.rotation);
            //audio
            AudioSource.PlayClipAtPoint(apperSound, transform.position);
            next.GetComponent<NextFruit>().Change();
        }
    }
}
