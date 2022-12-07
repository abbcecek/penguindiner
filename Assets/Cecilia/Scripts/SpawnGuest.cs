using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnGuest : MonoBehaviour
{
    public GameObject[] guests;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    public GameObject[] spawningPositions;



    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
        spawningPositions = GameObject.FindGameObjectsWithTag("Guest Pos");

        for (int i = 0; i < 5; i++)
        {
            SpawnObject(guests[i], spawningPositions[i]);
        }

       
   }

    // En funktion som spwanar mat på en plats
    public void SpawnObject(GameObject food, GameObject spawningPosition)
    {
        
        
       
           Instantiate(food, spawningPosition.transform.position, transform.rotation);
            
    }
}
