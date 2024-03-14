using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statue : MonoBehaviour
{
  private bool wasActivated = false;
  
internal void OnTriggerEnter2D(Collider2D other)
 {
	
		if(wasActivated == false)
	{
		if(other.gameObject.GetComponent<PlayerStats>())
		{
			StatueAction(other);
			wasActivated = true;
		}
		 
	}
  

}

internal virtual void StatueAction(Collider2D other)
{
	Debug.Log("Statue was activated");
}

}
