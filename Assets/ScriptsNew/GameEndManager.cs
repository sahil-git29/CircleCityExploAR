using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameEndManager : MonoBehaviour
{
    public TextMeshProUGUI totalScoreText;
    public GameManager gameManager; // Reference to the GameManager to access the total score.
    public GameObject gameEndUIPanel;


    public void ShowGameEndScreen()
    {
        // Get the total score from the GameManager.
        int totalScore = gameManager.collectibleScore;

        // Set the total score and congratulations text.
        totalScoreText.text = "Congratulations Your Total Score: " + totalScore.ToString();

        // Show the game end screen.
        gameEndUIPanel.SetActive(true);
    }
}
