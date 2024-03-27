using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class ActiveWeapon : MonoBehaviour 
{
	// Start is called before the first frame update
	
	//[SerializeField] private Sword sword;
	
	[SerializeField] internal Weapon weapon;
	[SerializeField] internal Weapon Basicweapon;

	[SerializeField] internal Weapon[] weapons;

	private bool isWeaponActivated = false;
	//private bool isChangePossible = false;

	// public enum Weapons
	// { //weapon list
	// 	noWeapon,
	// 	AncientSword,
	// 	Bow,
	// }

	//public Weapons myWeapons = Weapons.noWeapon;
	void Start()
	{
		weapons = FindObjectsOfType<Weapon>();
		WeaponsOff();
		//sword = GetComponentInChildren<Sword>();
		
	}
	
	internal void WeaponsOff()
	{
		foreach(Weapon weapon in weapons)
		{
			weapon.WeaponOff();
		}
		Basicweapon.WeaponOn();
	}
	// Update is called once per frame
	void Update()
	{
	
	}
	
	internal void SetPlayerActiveWepon(int weaponid)
	{
		Debug.Log($"Player got weapon id:{weaponid}");
		weapons[weaponid].WeaponOn();
		weapon = weapons[weaponid];
	}
}
	


	

