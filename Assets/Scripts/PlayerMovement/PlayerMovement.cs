using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;
    

    private Rigidbody _rb;
    private Vector3 _moveInput;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        _moveInput = new Vector3(x, 0f, z).normalized;
    }

    private void FixedUpdate()
    {
        Vector3 moveVelocity = _moveInput * _moveSpeed;
        Vector3 newVelocity = new Vector3(moveVelocity.x, _rb.linearVelocity.y, moveVelocity.z);

        _rb.linearVelocity = newVelocity;
    }
}
