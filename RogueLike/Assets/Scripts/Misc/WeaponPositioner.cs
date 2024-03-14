using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPositioner : MonoBehaviour
{
    // Script for weapon positioning. 

    [SerializeField] private Transform weaponCollider;
    [SerializeField] private Transform activeWeapon;
    [SerializeField] private PlayerController playerController;
    private void Update() {
        MouseFollowWithOffSet();
    }
     private void MouseFollowWithOffSet(){ 
        // todo change that to the script for using to the every weapon 

        Vector3 mousepos = Input.mousePosition; //Getting player mouse position on the screen
        Vector3 playerScreenPoint = Camera.main.WorldToScreenPoint(playerController.transform.position); // Getting player position vector on the camera.

        float angle = Mathf.Atan2(mousepos.y, mousepos.x) * Mathf.Rad2Deg; // calculate angle between mouse positon x and y

        if (mousepos.x < playerScreenPoint.x){ // if mouse is on the left side of the player change weapon possition and angle
            activeWeapon.transform.rotation = Quaternion.Euler(0, -180, angle);
            weaponCollider.transform.rotation = Quaternion.Euler(0, -180, angle);

        }else {
            activeWeapon.transform.rotation = Quaternion.Euler(0,0,angle);
            weaponCollider.transform.rotation = Quaternion.Euler(0, 0,angle);
        }
    }
}
 
