using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HittedAnimation : MonoBehaviour
{

private SpriteRenderer spriteRenderer;


private void Start() {
	 spriteRenderer = GetComponentInParent<SpriteRenderer>();
}
internal IEnumerator GotDamageIndicator()
	{
		/*
		Setting player damage indicator, changing color, can be changed for some animation event in the future. 

		*/
		spriteRenderer.color = Color.red; // change enemy color after got hitted
	
		yield return new WaitForSeconds(0.2f);
		
		spriteRenderer.color = Color.white;

	}

}
