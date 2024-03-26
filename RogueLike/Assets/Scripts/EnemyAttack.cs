using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{

	//simple enemy attack 
	[SerializeField] private int damagAmount = 1;
	private void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.GetComponent<PlayerStats>()){ // if gameobject is player take some damage amount from him 
			CameraShake playercam = FindAnyObjectByType<CameraShake>();
			PlayerStats playerStats = other.gameObject.GetComponent<PlayerStats>();
			playerStats.TakeDamage(damagAmount);
			
		}
	}
}


