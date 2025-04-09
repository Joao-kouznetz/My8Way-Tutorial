using UnityEngine;

public class UiManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject endgamePanel;
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GameController.isGameOver == true)
        {
            endgamePanel.SetActive(true);
        }

    }
}
