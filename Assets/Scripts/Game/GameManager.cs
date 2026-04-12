using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private float startTime = 60;
    [SerializeField] private TextMeshProUGUI timeText;

    private float time = 0;

    private bool onFinished;

    private void Start()
    {
        time = startTime;
        onFinished = false;
    }

    private void Update()
    {
        TimeManager();
    }

    private void TimeManager()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;

            int minute = (int)time / 60;
            int second = (int)time % 60;

            timeText.text = $"{minute:00}:{second:00}";
        }
        else
        {
            time = 0;

            if (!onFinished)
            {
                onFinished = true;
                Finished();
            }
        }
    }

    private void Finished()
    {
        GameDataManager.Instance.turnPoint += scoreManager.score;
        SceneManager.LoadScene("MenuScene");
    }
}
