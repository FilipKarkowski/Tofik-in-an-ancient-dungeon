using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnemyGenerator : MonoBehaviour
{
[SerializeField] private float spawnchance = 50f;
[SerializeField] private GameObject objecttospawn;


private void Start() {
if(Random.Range(0,100) <= spawnchance)
{
	if(objecttospawn != null)
	{
		Instantiate(objecttospawn, gameObject.transform.position, Quaternion.identity);
		Debug.Log("Spawned room mob");
	}
}
}


}
