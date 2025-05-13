using UnityEngine;
using System.Threading.Tasks;

// Replace with your online platform integration
public class OnlineManager : MonoBehaviour
{
    public static OnlineManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public async void SubmitScore(string levelID, float time)
    {
        Debug.Log($"[OnlineManager] Submitting score for {levelID}: {time:F2}s");
        await Task.Delay(500); // Simulate upload
    }
}
