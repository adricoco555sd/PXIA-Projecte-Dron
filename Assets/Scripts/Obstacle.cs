using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private float _damage = 25f;

    private void OnTriggerEnter(Collider other) {
        DroneController drone = other.GetComponent<DroneController>();

        if (drone != null) {
            drone.TakeDamage(_damage);
            Destroy(gameObject);
        }
    }
}