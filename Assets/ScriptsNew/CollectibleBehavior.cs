using UnityEngine;

public class CollectibleBehavior : MonoBehaviour
{
    public GameManager gameManager;
    public int collectibleIndex;

    private bool isClicked = false;

    private void OnMouseDown()
    {
        if (!isClicked)
        {
            isClicked = true;
            gameManager.CollectibleClicked(collectibleIndex);
        }
    }
}
