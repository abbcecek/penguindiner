using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Spawn : MonoBehaviour
{
    public GameObject[] foods;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    public GameObject[] spawningPositions;
    /*[SerializeField] private GameObject guest;*/


    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
        spawningPositions = GameObject.FindGameObjectsWithTag("Spawn pos");

        for (int i = 0; i < foods.Length; i++)
        {
            SpawnObject(foods[i], spawningPositions[i]);
        }
   }

    // En funktion som spwanar mat på en plats
    public void SpawnObject(GameObject food, GameObject spawningPosition)
    {
        /*if (guest.GetComponent<GuestOrder>().foodOrdered == true)
        {*/
            Instantiate(food, spawningPosition.transform.position, transform.rotation);
        /*}*/
    }
}
