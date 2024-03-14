using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoWeapon : Weapon
{
	// Start is called before the first frame update
	void Start()
	{
		Debug.Log("No weapons?");
	}

	// Update is called once per frame
	void Update()
	{
		
	}
		protected override void Awake()
	{
		myAnimator = GetComponent<Animator>();
		playerController = GetComponentInParent<PlayerController>();
		weaponPositioner = GetComponent<WeaponPositioner>();
		playerControls = new PlayerControls();
		activeWeapon = GetComponentInParent<ActiveWeapon>();
		currentWeapon = this.gameObject;
	}
		protected override void Attack()
	{
		myAnimator.SetTrigger("Attack"); //Attack animation trigger. 
	}
}
