using UnityEngine;

public class DroneController : MonoBehaviour
{
    private float _speed = 5f;
    private float _health = 100f;

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, moveY, 0f) * (_speed * Time.deltaTime);
        transform.Translate(movement);
    }

    public void TakeDamage(float amount)
    {
        _health -= amount;

        if (_health <= 0f)
        {
            Destroy(gameObject);
        }
    }
}