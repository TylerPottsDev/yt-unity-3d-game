using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {
    [SerializeField] Text scoreText;
    public float score = 0;

    private void Update() {
        score += Time.deltaTime;
    }

    private void OnGUI() {
        scoreText.text = Mathf.RoundToInt(score).ToString();
    }
}
