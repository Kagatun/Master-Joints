using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Core : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private float _maxSpeedY = -18f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (_rigidbody.velocity.y < _maxSpeedY)
            Destroy(gameObject);
    }
}
