using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 1.0f;

    public InputAction moveAction;

    private Vector2 inputAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // enable input reading to get values
        moveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        inputAction = moveAction.ReadValue<Vector2>();

        transform.Translate(Vector2.up * movementSpeed * Time.deltaTime * inputAction.y);
        transform.Translate(Vector2.right * movementSpeed * Time.deltaTime * inputAction.x);

    }
}
