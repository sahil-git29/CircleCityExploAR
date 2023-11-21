using UnityEngine;

public class GameManager : MonoBehaviour
{
    public UIManager uiManager;
    public GameObject[] collectibles;
    public string[] riddles;
    public string[] facts;
    public GameEndManager gameEndManager;
    public int maxCollectibles = 5; // Define the maximum number of collectibles.
    private int currentCollectibleIndex = -1;
    private bool riddlePanelOpen = false;
    public int collectibleScore = 0; // Initialize the score.

    void Start()
    {
        ShowInstructions();
    }

    public void StartGame()
    {
        HideInstructions();
        ShowNextRiddleAndCollectible();
    }

    public void ShowNextRiddleAndCollectible()
    {
        currentCollectibleIndex++;

        if (currentCollectibleIndex < collectibles.Length)
        {
            uiManager.HideRiddle();
            uiManager.HideCollectibleScoreUI();

            string riddle = riddles[currentCollectibleIndex];
            uiManager.ShowRiddle(riddle);
            uiManager.ShowTotalScore(collectibleScore);
            collectibles[currentCollectibleIndex].SetActive(true);
        }
        else
        {
            // End the game or show a victory message
            uiManager.HideCollectibleScoreUI();
            gameEndManager.ShowGameEndScreen();
        }
    }
        public void ShowRiddleButtonClicked()
        {
            // Assuming you have a variable like currentCollectibleIndex to track the current collectible index.
            if (currentCollectibleIndex >= 0 && currentCollectibleIndex < riddles.Length)
            {
                uiManager.ShowRiddleForCollectible(riddles[currentCollectibleIndex]);
            }
        }
    public void CollectibleClicked(int collectibleIndex)
    {
        if (collectibleIndex == currentCollectibleIndex && !riddlePanelOpen)
        {
            riddlePanelOpen = false;

            // Handle what happens when a collectible is clicked, e.g., show Collectible Score UI.
            collectibleScore++; // Update the score.
            if (collectibleScore > maxCollectibles)
            {
                // Show the game end screen with the total score.
                uiManager.ShowTotalScore(collectibleScore); // Update the total score UI.
            }
            else if(collectibleScore == maxCollectibles) {
                uiManager.ShowCollectibleScoreUI(facts[currentCollectibleIndex]);
                uiManager.ShowTotalScore(collectibleScore); // Update the total score UI.

            }
            else
            {
                //uiManager.UpdateCollectibleScore(collectibleScore); // Update the score displayed in the UI.
                uiManager.ShowCollectibleScoreUI(facts[currentCollectibleIndex]);
                uiManager.ShowTotalScore(collectibleScore); // Update the total score UI.
            }
        }
    }

    public void FindNextCollectible()
    {
        riddlePanelOpen = false;
        ShowNextRiddleAndCollectible();
    }

    private void ShowInstructions()
    {
        // Implement the logic to show instructions
        uiManager.instructionsPanel.SetActive(true);
    }

    private void HideInstructions()
    {
        // Implement the logic to hide instructions
        uiManager.instructionsPanel.SetActive(false);
    }
}

