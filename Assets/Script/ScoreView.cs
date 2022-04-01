using TMPro;
using UnityEngine;

namespace Assets.Script
{
    public class ScoreView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _score;
        [SerializeField] private ScoreCounter _scoreCounter;

        private void OnEnable()
        {
            _scoreCounter.ScoreChange += HandleScoreDelegate;
        }

        private void OnDisable()
        {
            _scoreCounter.ScoreChange -= HandleScoreDelegate;
        }

        private void Start()
        {
           HandleScoreDelegate();
        }

        public void HandleScoreDelegate()
        {           
            _score.text = $"Score:{_scoreCounter.Counter}";
        }
    }
}