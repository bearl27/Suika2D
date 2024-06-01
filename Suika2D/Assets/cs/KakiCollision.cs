using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KakiCollision : MonoBehaviour
{
    public GameObject Orange;

    void Update()
    {
        if(GameManager.gameOver)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "kaki")
        {
            // 自分のインスタンスIDと衝突相手のインスタンスIDを比較
            if (gameObject.GetInstanceID() < collision.gameObject.GetInstanceID())
            {
                Instantiate(Orange, transform.position, transform.rotation);
                Destroy(gameObject);
                GameManager.score += 20;
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
