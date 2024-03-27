using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSource : MonoBehaviour
{
	// Start is called before the first frame update
	[SerializeField] private int damageAmount =1;
	private void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.GetComponent<EnemyHealth>()){ // if collided object has enemyhealth scrit it will take damage
			EnemyHealth enemyHealth = other.gameObject.GetComponent<EnemyHealth>(); //taking from collided object health script 
			enemyHealth.TakeDamage(damageAmount);
			Debug.Log("Enemy was hitted!");
		}
		else if(other.gameObject.GetComponent<BossRoom>())
		{
			Destroy(other.gameObject);
		}
	}
}
