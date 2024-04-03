using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class RoomTemplates : MonoBehaviour
{
	public GameObject[] bottomRooms;
	public GameObject[] topRooms;
	public GameObject[] leftRooms;
	public GameObject[] rightRooms;
	
	
	public GameObject boosroomindicator;
	public GameObject closedRooms;
	
	public List<GameObject> rooms;
	
	public float waitTime;
	private bool spawnedBoss = false;
	
	public GameObject boss;
	
	private void Update() {
		if(waitTime <= 0 && spawnedBoss == false)
		{
			for(int i = 0; i < rooms.Count; i++)
			{
				if(i == rooms.Count-1)
				{
					Instantiate(boss, rooms[i].transform.position, Quaternion.identity);
					Instantiate(boosroomindicator, rooms[i].transform.position, Quaternion.identity);
					spawnedBoss = true;
					Debug.Log("Spawned boss");
				}
				
				Debug.Log(rooms.Count);
			}
		}
		else
		{
			waitTime -= Time.deltaTime;
		}
	}
	
}
