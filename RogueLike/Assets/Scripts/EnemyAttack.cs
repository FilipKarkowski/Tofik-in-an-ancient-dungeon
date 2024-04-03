using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{

	//simple enemy attack 
	[SerializeField] private int damagAmount = 1;
	private void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.GetComponent<PlayerStats>()){ // if gameobject is player take some damage amount from him 
			CameraShake playercam = FindAnyObjectByType<CameraShake>();
			PlayerStats playerStats = other.gameObject.GetComponent<PlayerStats>();
			HittedAnimation hittedAnimation = other.gameObject.GetComponent<HittedAnimation>();
			if(playerStats.defence < damagAmount)
			{
			playerStats.TakeDamage(damagAmount);
			}
			StartCoroutine(playercam.Shake(0.5f,0.5f));
			StartCoroutine(hittedAnimation.GotDamageIndicator());
			
		}
	}
}


