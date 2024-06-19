using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuikaCollision : MonoBehaviour
{
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
        if (collision.gameObject.tag == "suika")
        {
            AudioSource.PlayClipAtPoint(collisionSound, transform.position);
            Destroy(gameObject);
            GameManager.score += 100;
        }
    }
}
