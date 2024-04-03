using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellBook : Weapon
{
	// Start is called before the first frame update
	
	public Transform attackpoint;
	public GameObject spellattackprefab;
	
	public float attackforce = 20f;

	protected override void Attack()
	{
		if (this.gameObject.activeInHierarchy)
	{
		if(canattack){
		base.Attack();
		Spell();
		}
	}
	}
	// Update is called once per frame
	void Update()
	{
		
	}
	private void Spell()
	{
		GameObject spell = Instantiate(spellattackprefab, attackpoint.position, attackpoint.rotation);
		Rigidbody2D spellrb = spell.GetComponent<Rigidbody2D>();
		spellrb.AddForce(attackpoint.up * attackforce, ForceMode2D.Impulse);
		
	}
}
