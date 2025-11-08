using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int scoreValue = 0;
    
    void Start()
    {
        
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Destroy(gameObject);
            scoreValue += 1;
        }
    }
}
