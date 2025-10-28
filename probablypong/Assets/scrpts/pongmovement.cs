using Unity.VisualScripting;
using UnityEngine;

public class pongmovement : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed;

    private Vector2 direction;

    private Start move;

    private Vector2 velocity;

    public gamemanager gm;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
        rb = GetComponent<Rigidbody2D>();

        speed = 5f;

        float xstart = 0f;
        float ystart = 0f;

        direction = new Vector2(Random.Range(-1f,1f), Random.Range(1f,-1f));

        rb.linearVelocity = new Vector2(x: direction.x * speed, y: direction.y * speed);
        velocity = rb.linearVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hit");

        if (collision.gameObject.tag == "V")
        {
            rb.linearVelocity = new Vector2(x: velocity.x * -1, y: velocity.y);
        }

        if (collision.gameObject.tag == "H")
        {
            rb.linearVelocity = new Vector2(y: velocity.y * -1, x: velocity.x);
        }

        if(collision.gameObject.tag == "T")
        {
            rb.linearVelocity = new Vector2(x: velocity.x * -1, y: velocity.y);

            gm.score++;
        }

        velocity = rb.linearVelocity;

        
    }




}
