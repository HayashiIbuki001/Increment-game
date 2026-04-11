using UnityEngine;

public class TrashSpawner : MonoBehaviour
{
    [Header("参照")]
    [SerializeField] private Transform spawnPos;
    [SerializeField] private GameObject trashPrefab;

    [Header("詳細設定")]
    [SerializeField] private float trashSpawnCoolDown;

    private float coolDownTimer = 0;

    private void Update()
    {
        SpawnCoolDown();
    }

    private void SpawnCoolDown()
    {
        coolDownTimer += Time.deltaTime;

        if (coolDownTimer >= trashSpawnCoolDown)
        {
            SpawnTrash();
            coolDownTimer = 0;
        }
    }

    /// <summary> ゴミをスポーンさせる </summary>
    private void SpawnTrash()
    {
        Instantiate(trashPrefab, spawnPos.position, Quaternion.identity);
    }
}
