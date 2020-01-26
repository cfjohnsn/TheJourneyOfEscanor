using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;
    public float jumpHeight;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;
    private SpriteRenderer mySpriteRenderer;
    private Rigidbody2D rigidBody;

    // Use this for initialization
    private void Awake()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
    }

    void fixedUpdate()
    {

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
        }


        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);                        
            mySpriteRenderer.flipX = false;
            
        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            if(mySpriteRenderer != null)
            {
                mySpriteRenderer.flipX = true;
            }
        }

    }

    

    
}