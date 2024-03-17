using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRoom : MonoBehaviour
{
   private RoomTemplates roomTemplates;
   
   private void Start() {
	roomTemplates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
	roomTemplates.rooms.Add(this.gameObject);
   }
   
   
   
}
