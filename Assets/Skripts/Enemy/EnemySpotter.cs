using UnityEngine;

public class EnemySpotter : MonoBehaviour
{
    [SerializeField] private Collider _detectCollider;

    public Vector3 TrackingPosition { get; private set; }   

    private void Awake()
    {
        _detectCollider.isTrigger = true;
    }

    private void OnTriggerStay(Collider trigger)
    {
        if (trigger.TryGetComponent(out Player player))
        {
            TrackingPosition = player.transform.position;
        }
    }
}