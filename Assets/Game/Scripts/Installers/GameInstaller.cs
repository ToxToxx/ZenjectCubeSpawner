using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    [SerializeField] private GameObject cubePrefab;

    public override void InstallBindings()
    {
        Container
            .Bind<ICubeSpawner>()
            .To<CubeSpawner>()
            .AsSingle()
            .WithArguments(cubePrefab);
    }
}
