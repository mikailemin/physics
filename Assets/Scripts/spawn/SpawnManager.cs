using System.Collections;
using UnityEngine;


public class SpawnManager : MonoBehaviour
{
    public GameObject spawnPrefab;
    private float spawnDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("Spawnn", spawnDelay, spawnInterval);

    }

    // Update is called once per frame
    void Update()
    {
       
    }


    void Spawnn()
    {

        
            Instantiate(spawnPrefab, new Vector3(Random.Range(-3,3), 1, 150), spawnPrefab.transform.rotation);
        

    }
}
