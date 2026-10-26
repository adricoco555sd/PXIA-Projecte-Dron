using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _obstaclePrefab;
    [SerializeField] private float _spawnInterval = 2f;
    [SerializeField] private float _spawnRange = 5f;

    private float _timer;

    private void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= _spawnInterval)
        {
            SpawnObstacle();
            _timer = 0f;
        }
        
    }

    private void SpawnObstacle()
    {
        float randomX = Random.Range(-_spawnRange, _spawnRange);

        Vector3 spawnPosition = new Vector3(randomX, transform.position.y, 10f);

        Instantiate(_obstaclePrefab, spawnPosition, Quaternion.identity);
    }
}