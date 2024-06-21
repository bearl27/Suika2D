using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitsCollision : MonoBehaviour{
    public GameObject NextFruit;
    public AudioClip collisionSound;
    public int socreAddNum;//スコアの加算値

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == gameObject.tag)
        {
            // 自分のインスタンスIDと衝突相手のインスタンスIDを比較
            if (gameObject.GetInstanceID() < collision.gameObject.GetInstanceID())
            {
                //すいかの場合はNextFruitがnullなので生成しない
                if (NextFruit != null)
                {
                    //NextFruitを生成
                    Instantiate(NextFruit, transform.position, transform.rotation);
                }
                Destroy(gameObject);
                GameManager.score += socreAddNum;

            }
            else
            {
                AudioSource.PlayClipAtPoint(collisionSound, transform.position);
                Destroy(gameObject);
            }
        }
    }
}
