using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMover : MonoBehaviour
{
    private const string Horizontal = "Horizontal";
    private const string Vertical = "Vertical";

    [SerializeField] private float _speed;

    private CharacterController _characterController;

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Mover();
    }

    private void Mover()
    {
        Vector3 playerSpeed = new Vector3(Input.GetAxis(Horizontal), 0, Input.GetAxis(Vertical));
        playerSpeed *= Time.deltaTime * _speed;

        if (_characterController.isGrounded)
        {
            _characterController.Move(playerSpeed + Vector3.down);
        }
        else
        {
            _characterController.Move(_characterController.velocity + Physics.gravity * Time.deltaTime);
        }
    }
}
