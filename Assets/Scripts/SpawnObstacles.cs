using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject obstacle;
    private float _spawnInterval = 1f;

    public float minX = -5f;
    public float maxX = 5f;
    
    public float damage = 1f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), 0f, _spawnInterval);
    }

    void SpawnObstacle()
    {
        Vector3 spawnPosition = new Vector3(
            Random.Range(minX, maxX),
            transform.position.y,
            transform.position.z
        );

        Instantiate(obstacle, spawnPosition, Quaternion.identity);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        DroneController drone = other.GetComponent<DroneController>();

        if (drone != null)
        {
            drone.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
