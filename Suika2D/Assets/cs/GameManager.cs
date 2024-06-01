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
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
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
        if(time > 1.0f)
        {
            gameOver = true;
        }
        if(gameOver)
        {
            Destroy(GameObject.Find("Player"));
            gameOverGUI.SetActive(true);
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
