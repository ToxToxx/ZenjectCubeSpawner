using UnityEngine;
using Zenject;

public class ScoreManager : MonoBehaviour
{
    public int CurrentScore { get; private set; }
    private SignalBus _signalBus;

    [Inject]
    public void Construct(SignalBus signalBus)
    {
        _signalBus = signalBus;
    }

    private void OnEnable()
    {
        _signalBus.Subscribe<CubeSpawnedSignal>(OnCubeSpawned);
    }

    private void OnDisable()
    {
        _signalBus.Unsubscribe<CubeSpawnedSignal>(OnCubeSpawned);
    }

    private void OnCubeSpawned(CubeSpawnedSignal signal)
    {
        CurrentScore++;
        Debug.Log($"Cube spawned at {signal.Position}. Current score: {CurrentScore}");
    }
}
