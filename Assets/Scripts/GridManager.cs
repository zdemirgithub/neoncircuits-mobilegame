using UnityEngine;

public class GridManager : MonoBehaviour
{
    public GameObject tilePrefab;
    public Transform gridParent;

    public void GenerateGrid(LevelData levelData)
    {
        foreach (Transform child in gridParent)
            Destroy(child.gameObject);

        GameManager.Instance.tiles = new CircuitTile[levelData.gridSize, levelData.gridSize];

        for (int y = 0; y < levelData.gridSize; y++)
        {
            for (int x = 0; x < levelData.gridSize; x++)
            {
                GameObject tileObj = Instantiate(tilePrefab, gridParent);
                CircuitTile tile = tileObj.GetComponent<CircuitTile>();

                Vector2Int pos = new Vector2Int(x, y);
                var tileInfo = levelData.tiles[y * levelData.gridSize + x];

                tile.Initialize(tileInfo.type, pos, tileInfo.sprite);
                tileObj.GetComponent<Button>().onClick.AddListener(tile.OnClick);

                GameManager.Instance.tiles[x, y] = tile;
            }
        }
    }
}
