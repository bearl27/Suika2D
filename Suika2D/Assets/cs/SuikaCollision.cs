using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuikaCollision : MonoBehaviour
{

    void Update()
    {
        if(GameManager.gameOver)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "suika")
        {
            Destroy(gameObject);
            GameManager.score += 100;
        }
    }
}
