using UnityEngine;
using TMPro;

public class TimerManager : MonoBehaviour
{
    public TMP_Text timerText;
    public float gameDuration = 600.0f; // 10 minutes in seconds
    private float elapsedTime;
    public GameEndManager gameEndManager;
    private bool gameStarted = false;
    private bool gameEnded = false;

    void Update()
    {
        if (gameStarted && !gameEnded)
        {
            elapsedTime += Time.deltaTime;

            if (elapsedTime >= gameDuration)
            {
                // Game end condition: Timer reaches 00:00
                timerText.text = "00:00";
                gameEnded = true;
                OnGameEnd();
            }

            else
            {
                // Calculate remaining time
                float remainingTime = gameDuration - elapsedTime;
                int minutes = Mathf.FloorToInt(remainingTime / 60);
                int seconds = Mathf.FloorToInt(remainingTime % 60);

                // Update the timer TextMeshPro text
                timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
            }
            
        }
    }

    public void StartGame()
    {
        gameStarted = true;
    }

    private void OnGameEnd()
    {
        // Implement the game end logic, e.g., show the game end panel.
        gameEndManager.ShowGameEndScreen();
    }
}
