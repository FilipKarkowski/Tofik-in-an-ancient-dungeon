using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomCam : MonoBehaviour
{
public int roomid=0;
 public RoomCameraOptions[] values;
 public CameraFollow cam;
private void Start() {
    cam = FindObjectOfType<CameraFollow>();
    values = GetComponentsInChildren<RoomCameraOptions>();
}
private void OnTriggerEnter2D(Collider2D other) {
     if(other.CompareTag("Player")){
    cam.maxPos = values[0].value;
    cam.minPos = values[1].value;
    Debug.Log("Dziala");
        }
       
}

}
