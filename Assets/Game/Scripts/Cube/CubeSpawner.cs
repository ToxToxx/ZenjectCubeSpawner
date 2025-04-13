using UnityEngine;

public class CubeSpawner : ICubeSpawner
{
    private readonly GameObject _cubePrefab;

    public CubeSpawner(GameObject cubePrefab)
    {
        _cubePrefab = cubePrefab;
    }

    public void SpawnCube()
    {
        Object.Instantiate(_cubePrefab, Vector3.zero, Quaternion.identity);
    }
}
