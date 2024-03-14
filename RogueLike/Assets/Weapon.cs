using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class  Weapon : MonoBehaviour
{
	protected  WeaponPositioner weaponPositioner;
	
	protected  Animator myAnimator;
	protected  PlayerController playerController;
	protected PlayerControls playerControls;
	
	protected  ActiveWeapon activeWeapon;
	public GameObject currentWeapon;
	
	internal virtual void WeaponOn()
	{ // Method for ActiveWeapon setting.
	Debug.Log($"Activated a weapon named"+ this.gameObject.name);
		currentWeapon.gameObject.SetActive(true);
	}
	
	internal virtual void WeaponOff()
	{ // Method for ActiveWeapon setting.
	Debug.Log($"Deactivated a weapon named"+ this.gameObject.name);
		currentWeapon.gameObject.SetActive(false);
	}
	protected virtual void Awake()
	{
		myAnimator = GetComponent<Animator>();
		playerController = GetComponentInParent<PlayerController>();
		weaponPositioner = GetComponent<WeaponPositioner>();
		playerControls = new PlayerControls();
		activeWeapon = GetComponentInParent<ActiveWeapon>();
		currentWeapon = this.gameObject;
	}
		private void OnEnable()
	{
		playerControls.Enable();
	}
	
		void Start()
	{
		playerControls.Combat.Attack.started += _ => Attack(); // Activate attack method after player attack input from mouse.
	}
	
	protected virtual void Attack()
	{
		myAnimator.SetTrigger("Attack"); //Attack animation trigger. 
	}
}
