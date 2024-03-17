using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statue_Abilities : Statue
{
	[SerializeField] private Ability TowerAbility; 
	[SerializeField] private Ability[] abilities;
	
	[SerializeField] private float towerPower = 0.5f;
	private void Start() {
		abilities = FindObjectsOfType<Ability>();
		TowerAbility = abilities[Random.Range(0,abilities.Length)];
	 	
	}

	 internal override void StatueAction(Collider2D other)
	 {
		TowerAbility.AbilityBuff(towerPower);
	 }


}
