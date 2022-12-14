using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodPickupOriginal : MonoBehaviour
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
        if (other.gameObject.CompareTag("Table"))
        {
            foodFollow = false;
        }
    }
    private void Update()
    {
        if (foodFollow)
        {
            foodTransform.position = playerFoodPos.position;
            foodTransform.rotation =  transform.rotation;
        }

        if (Input.GetMouseButtonDown(0))
        {
            foodFollow = false;
        }
    }
}
