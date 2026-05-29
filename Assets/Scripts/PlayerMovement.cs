using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Vector2 directionalInput;
    Rigidbody2D myRigidbody2D;

    [SerializeField] float moveSpeed;

    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Run();
    }

    public void OnMove(InputValue value)
    {
        directionalInput = value.Get<Vector2>();

        Debug.Log(directionalInput);
    }

    void Run()
    {
        Vector2 playerVelocity = new Vector2(directionalInput.x, 0);
        myRigidbody2D.linearVelocity = playerVelocity * moveSpeed;
    }
}
