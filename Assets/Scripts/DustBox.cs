using UnityEngine;

public class DustBox : MonoBehaviour
{
    public ScoreManager scoreManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Trash"))
        {
            scoreManager.AddScore(1);
            Destroy(other.gameObject);
        }
    }
}
