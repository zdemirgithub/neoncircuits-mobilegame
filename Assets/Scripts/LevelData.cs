using UnityEngine;

[CreateAssetMenu(fileName = "LevelData", menuName = "NeonCircuits/LevelData")]
public class LevelData : ScriptableObject
{
    public string levelID;
    public int gridSize = 5;
    public TileInfo[] tiles;
}

[System.Serializable]
public struct TileInfo
{
    public CircuitTile.TileType type;
    public Sprite sprite;
}
