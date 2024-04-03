using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwap : MonoBehaviour
{
 [SerializeField] private ActiveWeapon aw; 

 [SerializeField] private Weapon weapontoset; 

private void Start() {
	aw = FindAnyObjectByType<ActiveWeapon>();
	
}

private void OnTriggerEnter2D(Collider2D other) {
	if(other.gameObject.GetComponent<PlayerStats>()){
	aw.WeaponsOff();
	aw.weapon = weapontoset;
	aw.Basicweapon = weapontoset;
	//weapontoset.WeaponOn();
	aw.SetCurrentWeapon();
	}
}
}
