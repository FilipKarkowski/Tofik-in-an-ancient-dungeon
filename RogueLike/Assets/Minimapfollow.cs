using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimapfollow : MonoBehaviour
{
public Transform target;
 public float smoothing;

 private void Start() {
	 target = FindObjectOfType<PlayerController>().transform;
 }
 private void FixedUpdate() {
	if(target != null){
		if(transform.position !=target.position){
				Vector3 targetpos = new Vector3(target.position.x,target.position.y, transform.position.z);
				 transform.position = Vector3.Lerp(transform.position,targetpos,smoothing);
		}
	}
 }
}