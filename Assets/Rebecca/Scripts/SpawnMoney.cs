using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnMoney : MonoBehaviour
{
    public GameObject[] money;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    public GameObject[] spawningPositions;



    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
        spawningPositions = GameObject.FindGameObjectsWithTag("Food pos");

        Debug.Log(spawningPositions.Length);
        for (int i = 0; i < spawningPositions.Length; i++)
        {
            SpawnObject(money[0], spawningPositions[i]);
        }

       
   }

    // En funktion som spwanar mat på en plats
    public void SpawnObject(GameObject food, GameObject spawningPosition)
    {
        
        
       
           Instantiate(food, spawningPosition.transform.position, transform.rotation);
            
    }
}
