using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class SeatSelector : MonoBehaviour
{
    private GameObject[] waypoints;
    private GameObject[] seats;
    private int currentWaypointIndex = 0;
    private GameObject guestSeat;
    private int seatIndex;
    int seatAmount;

    [SerializeField] private float speed = 2f;

    private void Start()
    {
        waypoints = GameObject.FindGameObjectsWithTag("Waypoint");
        seats = GameObject.FindGameObjectsWithTag("Seat");
        selectSeat();
    }

    private void Update()
    {
        findSeat();
    }

    private void selectSeat()
    {
        seatAmount = seats.Length;
        seatIndex = Random.Range(0, seatAmount);
        Debug.Log(seatIndex);
        guestSeat = seats[seatIndex];
    }

    private void findSeat()
    {
        if (Vector3.Distance(guestSeat.transform.position, transform.position) > .1f)
        {
            transform.position = Vector3.MoveTowards(transform.position, guestSeat.transform.position, Time.deltaTime * speed);
        }
    }

    private void followWaypoint()
    {
        if (Vector3.Distance(waypoints[currentWaypointIndex].transform.position, transform.position) < .1f)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
                if (Vector3.Distance(seats[0].transform.position, transform.position) >= .1f)
                {
                    transform.position = Vector3.MoveTowards(transform.position, seats[0].transform.position, Time.deltaTime * speed);
                }
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speed);
        }
    }
}
