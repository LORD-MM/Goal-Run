using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 7.0f;

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

        // player can move in all direction up, down, left and right
        transform.Translate(Vector2.up * playerSpeed * Time.deltaTime * inputAction.y);
        transform.Translate(Vector2.right * playerSpeed * Time.deltaTime * inputAction.x);

    }
}
