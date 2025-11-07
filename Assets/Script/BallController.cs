using NUnit.Framework;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody ballrb;
    
    public float jumpForce;
    public float gravityModifier; //

    public bool isOnGround = false;
    public bool isGameOver = false;
    private float lowerBoundForGameOver = -4f;

    public GameObject GameOverUi;
    
    void Start()
    {
        ballrb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        //fixing the x position change issue
        // if (ballrb.transform.position.x < 0 || ballrb.transform.position.x > 0)
        // {
        //     Debug.Log("changes in x position of ball !!!!!!!!");
        // }

        if(ballrb.transform.position.y < lowerBoundForGameOver)
        {
            isGameOver = true;
            GameOverUi.SetActive(true);
            
            // Debug.Log("game over!");
        }
        
        
        


        //fr mobile
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began && isOnGround)
            {
                jump();
                isOnGround = false;
                Debug.Log("jump");
            }
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Tile"))
        {
            isOnGround = true;
        }
    }

    void jump()
    {
        ballrb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
