using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Button StartButton;
    public Button GameOverButton;

    private void Start()
    {
        StartButton.onClick.AddListener(OnStartButtonClick);
        GameOverButton.onClick.AddListener(OnGameOverButtonClick);
    }

    private void OnStartButtonClick()
    {
        GameManager.Instance.SetGameState(GameManager.GameState.Playing);
    }

    private void OnGameOverButtonClick()
    {
        GameManager.Instance.SetGameState(GameManager.GameState.GameOver);
    }
}