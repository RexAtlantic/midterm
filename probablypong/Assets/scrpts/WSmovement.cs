
using UnityEngine;
using UnityEngine.InputSystem;

public class WSmovement : MonoBehaviour
{
    //variables

    public Rigidbody2D rb;

    public float movespeed;

    private Vector2 direction;

    public InputActionReference move;



   

    // Update is called once per frame
    void Update()
    {
        direction = move.action.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(y: direction.y * movespeed, x: direction.x = 0);
    }

}
