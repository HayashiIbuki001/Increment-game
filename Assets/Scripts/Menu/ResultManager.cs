using TMPro;
using UnityEngine;

public class ResultManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI resultText;

    private void Start()
    {
        int resultPoint = GameDataManager.Instance.turnPoint;
        resultText.text = resultPoint.ToString();
    }
}
