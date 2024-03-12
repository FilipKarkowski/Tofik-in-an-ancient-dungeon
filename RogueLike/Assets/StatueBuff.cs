using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatueBuff : MonoBehaviour
{
    private bool isBuffed = true;
    private ActiveWeapon activeWeapon;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(isBuffed == true){
        if(other.gameObject.GetComponent<PlayerStats>()){
            PlayerController player = other.gameObject.GetComponent<PlayerController>();
            ActiveWeapon weaps = other.gameObject.GetComponent<ActiveWeapon>();
            PlayerStats stats = other.gameObject.GetComponent<PlayerStats>();
            Debug.Log("Aktywowano wieze");
            isBuffed = false;
        }
           // weaps.myWeapons = ActiveWeapon.Weapons.AncientSword;
        }
    }
}
