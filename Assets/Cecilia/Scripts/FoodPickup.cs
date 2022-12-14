using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodPickup : MonoBehaviour
{
    [SerializeField] private Transform playerFoodPos;
    private GameObject foodObject;
    private Transform foodTransform;
    public bool foodFollow = false;

    List<string> availableFoods = new List<string>()
    {
        "Pizza",
        "Hotdog",
        "Hamburger",
        "Coffe",
        "Watermelon"
    };

    private void Start()
    {
        playerFoodPos = playerFoodPos.GetComponent<Transform>();
    }

    private void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < availableFoods.Count; i++)
        {
            if (other.gameObject.CompareTag(availableFoods[i]))
            {
                foodObject = other.gameObject;
                /*foodTransform = other.GetComponent<Transform>();*/
                foodFollow = true;
                foodObject.GetComponent<Collider>().isTrigger = false;
            }
        }
    }
    private void Update()
    {
        if (foodFollow)
        {
            foodObject.transform.position = playerFoodPos.position;
            foodObject.transform.rotation =  transform.rotation;
            
        }
        else
        {
            /*foodObject.GetComponent<Collider>().isTrigger = true;*/
        }

        if (Input.GetMouseButtonDown(0))
        {
            foodFollow = false;
            try
            {
                foodObject.GetComponent<Collider>().isTrigger = true;
            }
            catch { }
        }
    }
}
