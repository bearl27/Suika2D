using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeachCollision : MonoBehaviour
{
    public GameObject Suika;
    public AudioClip collisionSound;

    void Update()
    {
        if(GameManager.gameOver)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "peach")
        {
            // 自分のインスタンスIDと衝突相手のインスタンスIDを比較
            if (gameObject.GetInstanceID() < collision.gameObject.GetInstanceID())
            {
                Instantiate(Suika, transform.position, transform.rotation);
                Destroy(gameObject);
                GameManager.score += 40;
            }
            else
            {
                AudioSource.PlayClipAtPoint(collisionSound, transform.position);
                Destroy(gameObject);
            }
        }
    }
}
