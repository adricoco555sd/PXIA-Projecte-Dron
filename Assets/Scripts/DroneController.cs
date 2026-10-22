using UnityEngine;

public class DroneController : MonoBehaviour
{
    private int _speed = 10;
    private float _vides = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.Translate(new Vector3(0f, 0f, 0f));
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveX, moveY, 0f) * (_speed * Time.deltaTime);
        transform.Translate(movement);
    }
    
    public void TakeDamage(float amount)
    {
        _vides -= amount;

        if (_vides <= 0)
        {
            Destroy(gameObject);
        }
    }
}
