using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GridManager gridManager;
    public UIManager uiManager;
    public LevelData[] levels;
    public CircuitTile[,] tiles;

    private int currentLevelIndex = 0;
    private LevelData currentLevel;
    private float startTime;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        LoadLevel(0);
    }

    public void LoadLevel(int index)
    {
        currentLevelIndex = index;
        currentLevel = levels[index];
        gridManager.GenerateGrid(currentLevel);
        startTime = Time.time;
    }

    public void CheckCircuit()
    {
        if (IsCircuitComplete())
        {
            float time = Time.time - startTime;
            uiManager.ShowWinPanel(time);
            OnlineManager.Instance.SubmitScore(currentLevel.levelID, time);
        }
    }

    private bool IsCircuitComplete()
    {
        // Simplified placeholder check
        // Replace with graph traversal (DFS/BFS) from source to all targets
        return true; // Assume complete for now
    }

    public void RestartLevel() => LoadLevel(currentLevelIndex);

    public void NextLevel() => LoadLevel((currentLevelIndex + 1) % levels.Length);
}
