using UnityEngine;

public class Collectible : MonoBehaviour
{

    // public Vector3 rotationalSpeed = new Vector3(0, 100, 0);

    void Start()
    {

    }

    void Update()
    {
        // transform.Rotate(rotationalSpeed * Time.deltaTime);
         


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Destroy(gameObject);
        }
    }
}
