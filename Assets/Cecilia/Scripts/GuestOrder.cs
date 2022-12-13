using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class GuestOrder : MonoBehaviour
{
    List<string> availableFoods = new List<string>()
    {
        "Pizza",
        "Hotdog",
        "Hamburger",
        "Coffe",
        "Watermelon"
    };

    private string orderedFood;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            orderedFood = orderFood();
            Debug.Log("Food ordered!");
        }
        if (other.gameObject.CompareTag("Pizza"))
        {
            other.gameObject.transform.position = transform.position;
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
