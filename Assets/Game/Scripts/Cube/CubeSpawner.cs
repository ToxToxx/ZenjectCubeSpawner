using UnityEngine;
using Zenject;

public class CubeSpawner : ICubeSpawner
{
    private readonly GameObject _cubePrefab;
    private readonly Transform _spawnPoint;
    private readonly SignalBus _signalBus;

    public CubeSpawner(GameObject cubePrefab, Transform spawnPoint, SignalBus signalBus)
    {
        _cubePrefab = cubePrefab;
        _spawnPoint = spawnPoint;
        _signalBus = signalBus;
    }

    public void Spawn()
    {
        GameObject cube = Object.Instantiate(_cubePrefab, _spawnPoint.position, Quaternion.identity);
        _signalBus.Fire(new CubeSpawnedSignal(cube, cube.transform.position));
    }
}
