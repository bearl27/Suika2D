using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeCollision : MonoBehaviour
{
    public GameObject Peach;
    public AudioClip collisionSound;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "orange")
        {
            // 自分のインスタンスIDと衝突相手のインスタンスIDを比較
            if (gameObject.GetInstanceID() < collision.gameObject.GetInstanceID())
            {
                Instantiate(Peach, transform.position, transform.rotation);
                Destroy(gameObject);
                GameManager.score += 30;
            }
            else
            {
                AudioSource.PlayClipAtPoint(collisionSound, transform.position);
                Destroy(gameObject);
            }
        }
    }
}
