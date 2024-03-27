using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
 public Transform target;
 public float smoothing;
 public Vector2 maxPos;
 public Vector2 minPos;
 private void Start() {
	 target = FindObjectOfType<PlayerController>().transform;
 }
 private void FixedUpdate() {
	if(target != null){
		if(transform.position !=target.position){
				Vector3 targetpos = new Vector3(target.position.x,target.position.y, transform.position.z);
				targetpos.x =Mathf.Clamp(targetpos.x,minPos.x,maxPos.x);
				 targetpos.y =Mathf.Clamp(targetpos.y,minPos.y,maxPos.y);
				 transform.position = Vector3.Lerp(transform.position,targetpos,smoothing);
		}
	}
 }
}
