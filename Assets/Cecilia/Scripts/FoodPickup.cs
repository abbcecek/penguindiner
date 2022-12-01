using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodPickup : MonoBehaviour
{
    [SerializeField] private Transform playerFoodPos;
    private Transform foodTransform;
    private bool foodFollow = false;

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
                foodTransform = other.GetComponent<Transform>();
                foodFollow = true;
            }
        }
    }
    private void Update()
    {
        if (foodFollow)
        {
            foodTransform.position = playerFoodPos.position;
            foodTransform.rotation =  transform.rotation;
        }
    }
}
