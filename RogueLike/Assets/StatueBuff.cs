using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatueBuff : MonoBehaviour
{
	private bool isBuffed = true;
	private ActiveWeapon activeWeapon;
	

	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		
	}
	private void OnTriggerEnter2D(Collider2D other) {
		if(isBuffed == true){
		if(other.gameObject.GetComponent<PlayerStats>()){
			PlayerController player = other.gameObject.GetComponent<PlayerController>();
			ActiveWeapon weaps = other.gameObject.GetComponentInChildren<ActiveWeapon>();
			PlayerStats stats = other.gameObject.GetComponent<PlayerStats>();
		   // weaps.myWeapons = ActiveWeapon.Weapons.AncientSword;
		   	int possibleweapons = weaps.weapons.Length;
			Debug.Log($"Possible weapons:{weaps.weapons.Length} ");
			int randweapon = Random.Range(0,possibleweapons);
			Debug.Log($"Possible weapons:{randweapon} ");
			weaps.SetPlayerActiveWepon(randweapon);
			
			
			//isBuffed = false;
		}
		   // weaps.myWeapons = ActiveWeapon.Weapons.AncientSword;
		}
	}
}
