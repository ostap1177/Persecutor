using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMover : MonoBehaviour
{
    private const string C_horizontal = "Horizontal";
    private const string C_vertical = "Vertical";

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
        Vector3 playerSpeed = new Vector3(Input.GetAxis(C_horizontal), 0, Input.GetAxis(C_vertical));
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
