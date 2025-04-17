using UnityEngine.SceneManagement;
using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    [SerializeField] private GameObject cubePrefab;
    [SerializeField] private Transform spawnPoint;

    public override void InstallBindings()
    {
        SignalBusInstaller.Install(Container);
        Container.DeclareSignal<CubeSpawnedSignal>();

        // Spawner
        Container.Bind<ICubeSpawner>()
            .To<CubeSpawner>()
            .AsSingle()
            .WithArguments(cubePrefab, spawnPoint);

        // Другие зависимости
        Container.BindInterfacesAndSelfTo<ScoreManager>().FromComponentInHierarchy().AsSingle();
        Container.BindInterfacesAndSelfTo<ScoreDisplay>().FromComponentInHierarchy().AsSingle();
    }
}
