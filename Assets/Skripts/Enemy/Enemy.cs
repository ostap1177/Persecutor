using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private EnemyMover _mover;
    [SerializeField] private EnemySpotter _spotter;

    private void Update()
    {
        _mover.Move(_spotter.TrackingPosition);
    }
}
