using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;

    private void Update() {
        transform.Translate(Vector3.back * _speed * Time.deltaTime);
    }
}