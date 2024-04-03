using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMark : EnemyHealth
{
private EnemyHealth enemyHealth;


	internal override void TakeDamage(int DamageSource)
	{
	   currentHealth -= DamageSource; // take damage amount from the current health points.
		isDamaged = true; // sett object flag to the damaged
		knockBack.GetKnockedBack(PlayerController.Instance.transform, knockforce); 
		if(currentHealth <= 0){
			bossDeath();
			
		}
	}


	private void bossDeath(){

		Debug.Log("BossDeathAction");
	Destroy(gameObject);
	}

}
