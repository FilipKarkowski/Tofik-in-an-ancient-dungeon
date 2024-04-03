using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Claws : Weapon
{
	// Start is called before the first frame update
	[SerializeField] private Transform weaponCollider;

	//Animatio
	private GameObject slashAnim;
 // Weapon animator object
	[SerializeField] GameObject slashAnimPreFab; // SerializeField for slash animation prefab
	[SerializeField] Transform slashAnimSpawnPoint; // Invisible object for spawning slash animation 

	
	 internal override void WeaponOn()
	{ // Method for ActiveWeapon setting.
		base.WeaponOn();
		Debug.Log("WeaponOn Claws");
		//weaponCollider.gameObject.SetActive(true);
	}
	internal override void WeaponOff()
	{ // Method for ActiveWeapon setting.
		base.WeaponOff();
		Debug.Log("WeaponOff Claws");
		//weaponCollider.gameObject.SetActive(false);
	}

	protected override void Awake()
	{
		base.Awake();
	}
	
	public void DoneAttackingAnimationEvent()
	{
		
		weaponCollider.gameObject.SetActive(false); // Turning off weapon collider after atack end.
	}

	protected override void Attack()
	{
		if(canattack){
		base.Attack();
		weaponCollider.gameObject.SetActive(true);
		// Turning on weapon collider after attack start.
		}
	}
	public void AttackFlipAnimEvent()
	{
		slashAnim = Instantiate(slashAnimPreFab, slashAnimSpawnPoint.position, Quaternion.identity);
		slashAnim.transform.parent = this.transform.parent;
		if (playerController.FacingLeft)
		{
			slashAnim.GetComponent<SpriteRenderer>().flipX = true;
		}
		else
		{
			slashAnim.GetComponent<SpriteRenderer>().flipX = false;
		}

	}
}
