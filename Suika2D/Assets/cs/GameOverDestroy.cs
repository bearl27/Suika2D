using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverDestroy : MonoBehaviour
{
    void Update()
    {
        if(GameManager.gameOver)
        {
            Destroy(gameObject);
        }
    }
}
