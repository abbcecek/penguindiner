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
    private Collider spawnTrigger;
    [SerializeField] private GameObject spawnColliderObject;



    // Start is called before the first frame update
    void Start()
    {
        /*InvokeRepeating("SpawnObject", spawnTime, spawnDelay);*/
        spawningPositions = GameObject.FindGameObjectsWithTag("Guest Pos");
        spawnTrigger = spawnColliderObject.GetComponent<Collider>();

        /*for (int i = 0; i < 5; i++)
        {
            SpawnObject(guests[i], spawningPositions[i]);
        }*/
   }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            for (int i = 0; i < guests.Length; i++)
            {
                SpawnObject(guests[i], spawningPositions[i]);
            }
        }
    }

    // En funktion som spawnar en gäst på en plats
    public void SpawnObject(GameObject guest, GameObject spawningPosition)
    {
        
        Instantiate(guest, spawningPosition.transform.position, transform.rotation);
            
    }
}
