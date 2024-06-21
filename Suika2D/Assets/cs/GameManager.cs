using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static public int score = 0;
    static public bool gameOver = false;
    private bool gameOverTime = false;
    private float time = 0.0f;
    public GameObject gameOverGUI;
    public GameObject player;

    void Start()
    {
        score = 0;
        gameOver = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

        if(gameOverTime)
        {
            time += Time.deltaTime;
        }
        if(time > 2.0f)
        {
            gameOver = true;
        }
        if(gameOver)
        {
            player.SetActive(false);
            gameOverGUI.SetActive(true);
        }else{
            player.SetActive(true);
            gameOverGUI.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        gameOverTime = true;
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        gameOverTime = false;
        time = 0.0f;
    }
}
