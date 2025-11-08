

using UnityEngine;

public class Repeatbackground : MonoBehaviour
{
    
    public float loopSpeed;
    public Renderer bgRenderer;

    private BallController ballControllerScript;

    void Start()
    {
        ballControllerScript = GameObject.Find("Ball").GetComponent<BallController>();
    }
    void Update()
    {
        if(ballControllerScript.isGameOver == false)
        {
            bgRenderer.material.mainTextureOffset += new Vector2(loopSpeed * Time.deltaTime, 0f);
        }
        // bgRenderer.material.mainTextureOffset += new Vector2(loopSpeed * Time.deltaTime, 0f);
    }
}
