using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExploringRoomMinimap : MonoBehaviour
{
	// Start is called before the first frame update
	SpriteRenderer sr; 
	
	
	private bool isExplored = false;
	
	
	
	private void Start() {
		sr = GetComponent<SpriteRenderer>();
	}
	private void OnTriggerEnter2D(Collider2D other) {
		 if(other.CompareTag("Player"))
		 {
		 isExplored = true;	
		 sr.enabled = true;	
			
		 }
	}

}
