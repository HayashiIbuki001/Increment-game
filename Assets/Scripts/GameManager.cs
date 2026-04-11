using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float startTime = 60;
    [SerializeField] private TextMeshProUGUI timeText;

    private float time = 0;

    private void Start()
    {
        time = startTime;
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
        }
    }
}
