using UnityEngine;
using UnityEngine.UI;

public class GameExit : MonoBehaviour
{
    private Button exitButton;

    private void Start()
    {
        exitButton = GetComponent<Button>();
        exitButton.onClick.AddListener(ExitGame);
    }

    private void ExitGame()
    {
        Application.Quit();
    }
}