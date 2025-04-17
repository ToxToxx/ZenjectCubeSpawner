using UnityEngine;
using TMPro;
using Zenject;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    private SignalBus _signalBus;
    private ScoreManager _scoreManager;

    [Inject]
    public void Construct(SignalBus signalBus, ScoreManager scoreManager)
    {
        _signalBus = signalBus;
        _scoreManager = scoreManager;
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
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + _scoreManager.CurrentScore;
    }
}
