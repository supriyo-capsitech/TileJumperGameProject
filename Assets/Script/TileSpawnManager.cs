
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class TileSpawnManager : MonoBehaviour
{
    public GameObject tilePrefab;
    public GameObject collectiblesPrefab;

    private float startDelay = 0f;
    private float repeatDelay = 2.0f;

    //range of random y
    private float minY = -1f;
    private float maxY = 2f;

    private float collectibleOffsetY = 1.0f; //coin above dist

    private BallController ballControllerScript; // to get gameover bool




    void Start()
    {
        ballControllerScript = GameObject.Find("Ball").GetComponent<BallController>();

        InvokeRepeating("SpawnTileAndCollectibles", startDelay, repeatDelay);

    }


    void Update()
    {


    }

    void SpawnTileAndCollectibles()
    {
        float randomY = GetRandomY();
        float collectibleOffsetX = Random.Range(-3f,3f);

        // float randomY = Random.Range(minY, maxY);
        Vector3 tileSpawnPos = new Vector3(35, randomY, 0);
        Vector3 collectiblePos = new Vector3(tileSpawnPos.x+ collectibleOffsetX, tileSpawnPos.y + collectibleOffsetY, tileSpawnPos.z);

        if (ballControllerScript.isGameOver == false)
        {
            Instantiate(tilePrefab, tileSpawnPos, tilePrefab.transform.rotation);
            Instantiate(collectiblesPrefab, collectiblePos, collectiblesPrefab.transform.rotation);

        }

    }

    float GetRandomY()  //for tile y
    {
        return Random.Range(minY, maxY);
    }


}
