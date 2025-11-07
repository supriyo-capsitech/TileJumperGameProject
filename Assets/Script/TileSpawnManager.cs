using UnityEngine;
using UnityEngine.Rendering.Universal;

public class TileSpawnManager : MonoBehaviour
{
    public GameObject tilePrefab;

    public float startDelay = 0f;
    public float repeatDelay = 3.0f;

    // public Vector3 tileSpawnPos = new Vector3(35, 0, 0);

    //range of random y
    private float minY = -1f;
    private float maxY = 2f;

    private BallController ballControllerScript; // gameover




    void Start()
    {
        ballControllerScript = GameObject.Find("Ball").GetComponent<BallController>();

        InvokeRepeating("SpawnTile", startDelay, repeatDelay);

    }


    void Update()
    {


    }

    void SpawnTile()
    {
        float randomY = Random.Range(minY, maxY);
        Vector3 tileSpawnPos = new Vector3(35, randomY, 0);

        if (ballControllerScript.isGameOver == false)
        {
            Instantiate(tilePrefab, tileSpawnPos, tilePrefab.transform.rotation);

        }

    }
}
