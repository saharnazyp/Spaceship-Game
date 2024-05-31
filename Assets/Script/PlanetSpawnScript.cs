using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSpawnScript : MonoBehaviour
{
    public GameObject Planet;
    private float timer = 0f;
    public float spawnRate = 3f;
    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnPlanet();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        { 
            timer = timer + Time.deltaTime; 
            
        }
        else
        {

            spawnPlanet();
            timer = 0f;
        }
            

    }

    void spawnPlanet()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(Planet, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
