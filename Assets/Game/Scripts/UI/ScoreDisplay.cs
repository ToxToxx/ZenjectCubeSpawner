using UnityEngine;
using Zenject;

public class ScoreDisplay : MonoBehaviour
{
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
        Debug.Log("Куб заспавнился на позиции: " + signal.Position);
    }
}
