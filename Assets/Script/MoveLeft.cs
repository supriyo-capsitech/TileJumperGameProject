using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 10f;

    public float leftBound = -33f;

    private BallController ballControllerScript;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ballControllerScript = GameObject.Find("Ball").GetComponent<BallController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ballControllerScript.isGameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        // transform.Translate(Vector3.left * Time.deltaTime * speed);
        
    }
}
