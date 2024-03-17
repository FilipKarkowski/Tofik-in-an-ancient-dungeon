using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
 public int openingDirection;
 // 1 - need bottom door. 
 // 2 - need top door.
 // 3 - need left door.
 // 4 - need right door.
 
 [SerializeField] private bool spawned = false;
 private RoomTemplates roomTemplates;
 
 private int Rand;
 private void Start() {
	roomTemplates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
	Invoke("Spawn", 0.1f);
}
 private void Spawn() {
	if(spawned == false){
	switch (openingDirection)
	{
		case 1:
		Rand = Random.Range(0,roomTemplates.bottomRooms.Length);
		Instantiate(roomTemplates.bottomRooms[Rand],transform.position,roomTemplates.bottomRooms[Rand].transform.rotation);
		Debug.Log($"room: {this.transform.parent.name}, spawned room in {this.name} spawnpoint ");
		break;
		case 2:
		// need to spawn rom with top door
		Rand = Random.Range(0,roomTemplates.topRooms.Length);
		Instantiate(roomTemplates.topRooms[Rand],transform.position,roomTemplates.topRooms[Rand].transform.rotation);
		Debug.Log($"room: {this.transform.parent.name}, spawned room in {this.name} spawnpoint ");
		break;
		case 3:
		// need to spawn rom with left door
		Rand = Random.Range(0,roomTemplates.leftRooms.Length);
		Instantiate(roomTemplates.leftRooms[Rand],transform.position,roomTemplates.leftRooms[Rand].transform.rotation);
		Debug.Log($"room: {this.transform.parent.name}, spawned room in {this.name} spawnpoint ");
		break;
		case 4:
		// need to spawn rom with right door
		Rand = Random.Range(0,roomTemplates.rightRooms.Length);
		Instantiate(roomTemplates.rightRooms[Rand],transform.position,roomTemplates.rightRooms[Rand].transform.rotation);
		Debug.Log($"room: {this.transform.parent.name}, spawned room in {this.name} spawnpoint ");
		break;

	}
	spawned = true;
	}
 }
 private void OnTriggerEnter2D(Collider2D other) {
	if(other.CompareTag("SpawnPoint"))
	{
		if(other.GetComponent<RoomSpawner>().spawned == false && spawned == false )
		{
			roomTemplates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
			Instantiate(roomTemplates.closedRooms,transform.position, Quaternion.identity);
			Debug.Log($"Closed room created");
			Destroy(gameObject);
		}
		spawned = true;
	}
 }
}
