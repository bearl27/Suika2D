using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    public GameObject scoreText;
    void Start()
    {
        scoreText.GetComponent<TextMesh>().text = "Score: " + GameManager.score;
    }

    //scoreに変更があった場合に更新
    void Update()
    {
        scoreText.GetComponent<TextMesh>().text = "Score: " + GameManager.score;
    }
}
