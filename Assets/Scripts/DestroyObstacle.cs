using UnityEngine;

public class DestroyObstacleNewMonoBehaviourScript : MonoBehaviour
{
    private float _lifetime = 4f;

    private void Start() {
        Destroy(gameObject, _lifetime);
    }
}