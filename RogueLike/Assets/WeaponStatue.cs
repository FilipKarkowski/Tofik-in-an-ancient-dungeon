using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStatue : Statue
{
	private ActiveWeapon activeWeapon;
	
	internal override void StatueAction(Collider2D other)
	{
	
	ActiveWeapon aw = other.gameObject.GetComponentInChildren<ActiveWeapon>();
	aw.SetPlayerActiveWepon((Random.Range(0,aw.weapons.Length)));
	Debug.Log("Statue was activated");
	}
	


	
}
