using UnityEngine;
using UnityEngine.UI;
public class GameRetry : MonoBehaviour
{
    private Button retryButton;

    private void Start()
    {
        retryButton = GetComponent<Button>();

        retryButton.onClick.AddListener(RetryGame);
    }

    private void RetryGame()
    {
        GameManager.score = 0;
        GameManager.gameOver = false;
    }
}

