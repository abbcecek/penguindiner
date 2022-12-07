using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int money = 0;
    [SerializeField] private Text moneyText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Money"))
        {
            Destroy(collision.gameObject);
            money += 15;
            moneyText.text = "Money: " + money;
        }
    }
}
