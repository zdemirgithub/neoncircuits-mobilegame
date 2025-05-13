using UnityEngine;
using UnityEngine.UI;

public class CircuitTile : MonoBehaviour
{
    public Image tileImage;
    public int rotationState = 0;
    public Vector2Int gridPosition;
    public TileType type;
    public bool isPowered = false;

    public enum TileType { Straight, Corner, Tee, Cross, Source, Target }

    public void Initialize(TileType tileType, Vector2Int pos, Sprite sprite)
    {
        type = tileType;
        gridPosition = pos;
        tileImage.sprite = sprite;
        rotationState = 0;
        transform.rotation = Quaternion.identity;
    }

    public void OnClick()
    {
        RotateTile();
        GameManager.Instance.CheckCircuit();
    }

    private void RotateTile()
    {
        rotationState = (rotationState + 1) % 4;
        transform.Rotate(Vector3.forward, -90f);
    }
}
