using TMPro;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreText2;

    void Update()
    {
        if (scoreText != null)
        {
            scoreText.text = "score: " + GameManager.score;
        }
        if (scoreText2 != null)
        {
            scoreText2.text = GameManager.score.ToString();
        }
    }
}