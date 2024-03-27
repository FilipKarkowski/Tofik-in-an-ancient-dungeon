using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph;
using UnityEngine;

public class AB_DecreeseWeaponCD : Ability
{
	// Start is called before the first frame update
	
	ActiveWeapon activeWeapon; 
	SpriteRenderer sr;
	
	internal override void Start()
	{
		base.Start();
		activeWeapon = FindAnyObjectByType<ActiveWeapon>();
	}

	internal override void AbilityBuff(float BuffStrenght)
	{
		activeWeapon.weapon.AttackCoolDown -= Random.Range(1,(activeWeapon.weapon.AttackCoolDown/2));
		sr = activeWeapon.weapon.GetComponent<SpriteRenderer>();
		sr.color = Color.red;
	}

}
