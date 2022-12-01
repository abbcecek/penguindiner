using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodPickup : MonoBehaviour
{
    [SerializeField] private Transform playerFoodPos;
    private Transform foodTransform;

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
        playerFoodPos = GetComponent<Transform>();
    }

    private void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < availableFoods.Count; i++)
        {
            if (other.gameObject.CompareTag(availableFoods[i]))
            {
                foodTransform = other.GetComponent<Transform>();
                foodTransform = (playerFoodPos.x, playerFoodPos.y, playerFoodPos.z);
            }
        }
    }
}
