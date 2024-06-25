using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private EnemyMover _enemyMover;
    [SerializeField] private EnemySpotter _enemySpotter;

    private void Update()
    {
        _enemyMover.Move(_enemySpotter.TrackingPosition);
    }
}
