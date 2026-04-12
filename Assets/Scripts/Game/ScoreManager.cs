using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;

    public int score = 0;

    private void Start()
    {
        UpdateUI();    
    }

    public void AddScore(int value)
    {
        score += value;
        UpdateUI();
    }

    private void UpdateUI()
    {
        text.text = $"Point : {score.ToString()}";
    }
}
