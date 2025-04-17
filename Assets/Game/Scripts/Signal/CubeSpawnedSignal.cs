using UnityEngine;

public class CubeSpawnedSignal
{
    public GameObject CubeObject { get; }
    public Vector3 Position { get; }

    public CubeSpawnedSignal(GameObject cubeObject, Vector3 position)
    {
        CubeObject = cubeObject;
        Position = position;
    }
}
