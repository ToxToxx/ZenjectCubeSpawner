using UnityEngine;
using Zenject;

public class ScoreManager : MonoBehaviour
{
    private int _score;

    [Inject]
    public void OnCubeSpawned(CubeSpawnedSignal signal)
    {
        // Увеличиваем счёт каждый раз, когда куб спавнится
        _score++;
        Debug.Log($"Cube spawned at {signal.Position}. Current score: {_score}");
    }
}
