using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveWeapon : MonoBehaviour 
{
    // Start is called before the first frame update
    
    [SerializeField] private Sword sword;

    private bool isWeaponActivated = false;
    private bool isChangePossible = false;

    public enum Weapons{ //weapon list
        noWeapon,
        AncientSword,
        Bow,
    }

    public Weapons myWeapons = Weapons.noWeapon;
    void Start()
    {
        sword = GetComponentInChildren<Sword>();
    }
    // Update is called once per frame
    void Update()
    {
        if(!isWeaponActivated){ // if player has no weapon check his weapons until got assigned 
        weaponChecker();
        }
    }

    private void weaponChecker(){ //Check current player weapon 
     switch (myWeapons){
        case Weapons.noWeapon:
            sword.SwordOff();

        break;

        case Weapons.AncientSword:
            sword.SwordOn();
            Debug.Log("Weapon was changed to the ancient sword");
            isWeaponActivated = true;
        break;

        case Weapons.Bow:

        break;



    }


    }
}
