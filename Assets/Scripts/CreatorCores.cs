using UnityEngine;

public class CreatorCores : MonoBehaviour
{
    [SerializeField] private Core _core;
    [SerializeField] private Recharge _recharge;
    [SerializeField] private Transform _spawnPoint;

    private void OnEnable()
    {
        _recharge.Loaded += CreateCore;
    }

    private void OnDisable()
    {
        _recharge.Loaded -= CreateCore;
    }

    private void CreateCore() =>
        Instantiate(_core, _spawnPoint.position, Quaternion.identity);
}
