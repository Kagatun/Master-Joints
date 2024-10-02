using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(SpringJoint))]
public class Catapult : MonoBehaviour
{
    [SerializeField] private Shooting _shooting;
    [SerializeField] private Rigidbody _starter;
    [SerializeField] private Rigidbody _charger;

    private SpringJoint _springJoint;
    private WaitForSecondsRealtime _wait;
    private float _timeSwap = 1;

    private void Awake()
    {
        _wait = new WaitForSecondsRealtime(_timeSwap);
        _springJoint = GetComponent<SpringJoint>();
    }

    private void OnEnable()
    {
        _shooting.Fired += Shoot;
    }

    private void OnDisable()
    {
        _shooting.Fired -= Shoot;
    }

    private void Shoot() =>
        StartCoroutine(Fire());

    private IEnumerator Fire()
    {
        _springJoint.connectedBody = _starter;

        yield return _wait;

        _springJoint.connectedBody = _charger;
    }
}
