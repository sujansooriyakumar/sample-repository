using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public InputAction moveInput;
    public float speed;
    private Vector3 moveVector;
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveInput.Enable();
        moveInput.performed += OnPlayerMove;
        moveInput.canceled += OnPlayerMove;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += moveVector * Time.deltaTime * speed;
        if (moveVector != Vector3.zero) animator.SetBool("isWalking", true);
        else
        {
            animator.SetBool("isWalking", false);
        }
    }
    void OnPlayerMove(InputAction.CallbackContext c)
    {
        moveVector = new Vector3(c.ReadValue<Vector2>().x, 0, c.ReadValue<Vector2>().y);
        
    }
}
