using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private EnemyMover _enemyMover;
    [SerializeField] private EnemySpotter _enemySpotter;

    private void Update()
    {
        _enemyMover.Move(_enemySpotter.TrackingPosition);
        Debug.Log($"Tracking {_enemySpotter.TrackingPosition}");
    }
}
