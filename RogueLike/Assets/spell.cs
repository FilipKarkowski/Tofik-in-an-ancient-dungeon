using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spell : MonoBehaviour
{
[SerializeField] internal float spellrange = 1f;
[SerializeField] internal int spelldamage = 2;


[SerializeField] private PlayerStats ps;

private void Start() {
	ps = FindAnyObjectByType<PlayerStats>();
	StartCoroutine(spellRoutine());
}
private IEnumerator spellRoutine()
{
yield return new WaitForSeconds(spellrange);
Destroy(gameObject);
	
}


private void OnTriggerEnter2D(Collider2D other) {
		
		if(other.gameObject.GetComponent<EnemyHealth>()){ // if collided object has enemyhealth scrit it will take damage
			EnemyHealth enemyHealth = other.gameObject.GetComponent<EnemyHealth>(); //taking from collided object health script 
			enemyHealth.TakeDamage(spelldamage*ps.strength);
			Debug.Log("Enemy was hitted!");
		}
		else if(other.gameObject.CompareTag("Obstacle"))
		{
			Destroy(gameObject);
		}
	}

}
