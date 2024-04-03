using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomItems : MonoBehaviour
{
[SerializeField] private GameObject[] items;

[SerializeField] private int spawnchance = 50;

private int Rand;
private void Start() {

if(Random.Range(0,100) <= spawnchance)
{
	Rand = Random.Range(0,items.Length);
	if(items != null)
	{
		Instantiate(items[Rand], gameObject.transform.position, Quaternion.identity);
		Debug.Log("Spawned room item");
	}
}

}

}
