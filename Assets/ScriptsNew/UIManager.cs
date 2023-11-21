using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject instructionsPanel;
    public TextMeshProUGUI instructionsText;
    public GameObject riddlePanel;
    public Button riddleIcon;
    public Button riddleCloseButton;
    public TextMeshProUGUI riddleText;
    public TextMeshProUGUI factText;
    public GameObject collectibleScoreUIPanel;
    public TextMeshProUGUI collectibleScoreText;
    public TextMeshProUGUI totalScoreText;
    public GameObject gameEndUIPanel;

    public void ShowInstructions(string instructions)
    {
        instructionsText.text = instructions;
        instructionsPanel.SetActive(true);
    }

    public void HideInstructions()
    {
        instructionsPanel.SetActive(false);
    }
    public void ShowRiddleForCollectible(string riddle)
    {
        riddleText.text = riddle;
        riddlePanel.SetActive(true);
    }

    public void ShowRiddle (string riddle)
    {
        riddleText.text = riddle;
        riddlePanel.SetActive(true);
    }
    public void HideRiddle()
    {
        riddlePanel.SetActive(false);
    }
    public void HideGameEndPanel()
    {
        gameEndUIPanel.SetActive(false);
    }
    public void ShowCollectibleScoreUI(string fact)
    {
        factText.text = fact;
        collectibleScoreUIPanel.SetActive(true);

    }

    public void HideCollectibleScoreUI()
    {
        collectibleScoreUIPanel.SetActive(false);
    }

    public void UpdateCollectibleScore(int score)
    {
        collectibleScoreText.text = "Artifact Collected\r\nYour score " + score.ToString();
    }

    public void ShowTotalScore(int collectibleScore)
    {
        totalScoreText.text = collectibleScore.ToString() + "/5";
    }

    
}
