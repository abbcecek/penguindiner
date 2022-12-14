using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class GuestOrder : MonoBehaviour
{
    [SerializeField] private Transform foodPos;
    private GameObject foodObject;
    private GameObject Player;
    private bool foodOrdered = false;
    private string orderedFood;

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
        foodPos = foodPos.GetComponent<Transform>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !foodOrdered)
        {
            orderedFood = orderFood();
            Debug.Log("Food ordered!");
            foodOrdered = true;
            Player = other.gameObject;
        }

        Debug.Log(other.gameObject.tag);

        if (other.gameObject.CompareTag("Pizza") && foodOrdered)
        {
            Debug.Log("Takes food");

            foodObject = other.gameObject;
            Player.GetComponent<FoodPickup>().foodFollow = false;
            foodObject.transform.position = foodPos.position;
        }
    }

    private string orderFood()
    {
        /*int index = Random.Range(0, availableFoods.Count);
        string order = availableFoods[index];*/
        string order = "Pizza";
        Debug.Log("Ordering food");

        return order;
    }
}
