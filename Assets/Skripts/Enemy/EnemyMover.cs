using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _gravityValue = -1;
    [SerializeField] private float _distance;


    private Rigidbody _rigidbody;
    private Transform _transform;

    private void Awake()
    {
        _transform = transform;
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 position)
    {
        if (Vector3.Distance(position, _transform.position) > _distance)
        {
            _rigidbody.velocity = new Vector3(position.x - _transform.position.x, _gravityValue, position.z - _transform.position.z).normalized * _speed * Time.deltaTime;
        }
        else 
        {
            _rigidbody.velocity = Vector3.zero; 
        }
    }
}
