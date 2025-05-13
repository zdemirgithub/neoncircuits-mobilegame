using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject winPanel;
    public TMP_Text timeText;

    public void ShowWinPanel(float time)
    {
        timeText.text = $"Time: {time:F2}s";
        winPanel.SetActive(true);
    }

    public void OnRestartClicked() => GameManager.Instance.RestartLevel();

    public void OnNextLevelClicked() => GameManager.Instance.NextLevel();
}
