using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Swing : MonoBehaviour
{
    [SerializeField] private Rocking _rocking;

    private Rigidbody _rigidbody;
    private float _force = 30f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        _rocking.Swung += Sway;
    }

    private void OnDisable()
    {
        _rocking.Swung -= Sway;
    }

    private void Sway() =>
        _rigidbody.AddForce(transform.right * _force, ForceMode.Impulse);
}
