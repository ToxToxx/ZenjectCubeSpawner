using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class UIController : MonoBehaviour
{
    [SerializeField] private Button spawnButton;

    private ICubeSpawner _spawner;

    [Inject]
    public void Construct(ICubeSpawner spawner)
    {
        _spawner = spawner;
    }

    private void Start()
    {
        spawnButton.onClick.AddListener(() => _spawner.Spawn());
    }
}
