using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class Sword : MonoBehaviour
{
    // Start is called before the first frame update
    //Object
    private WeaponPositioner weaponPositioner;
    //Colider
    [SerializeField] private Transform weaponCollider;

    //Animation
    
    private GameObject slashAnim;
    private Animator myAnimator; // Weapon animator object
    [SerializeField] GameObject slashAnimPreFab; // SerializeField for slash animation prefab
    [SerializeField] Transform slashAnimSpawnPoint; // Invisible object for spawning slash animation 


    //Player
    private PlayerController playerController;
    private PlayerControls playerControls;


    private ActiveWeapon activeWeapon;
    private Sword sword;

   

   
    private void Awake() {
        playerController = GetComponentInParent<PlayerController>();
        weaponPositioner = GetComponent<WeaponPositioner>();
        activeWeapon = GetComponentInParent<ActiveWeapon>();
        playerControls = new PlayerControls();
        myAnimator = GetComponent<Animator>();
        sword = this;
    }

     public void SwordOn(){ // Method for ActiveWeapon setting.
        weaponCollider.gameObject.SetActive(true);
        sword.gameObject.SetActive(true);
    }
    public void SwordOff(){ // Method for ActiveWeapon setting.
        weaponCollider.gameObject.SetActive(false);
        sword.gameObject.SetActive(false);
    }
    void Start()
    {
       playerControls.Combat.Attack.started += _ => Attack(); // Activate attack method after player attack input from mouse.
    }
    private void OnEnable() {
        playerControls.Enable();
    }
    private void Update() {
    
    }
      public void DoneAttackingAnimationEvent(){
        weaponCollider.gameObject.SetActive(false); // Turning off weapon collider after atack end.
    }

    private void Attack(){
        myAnimator.SetTrigger("Attack"); //Attack animation trigger. 
        weaponCollider.gameObject.SetActive(true); // Turning on weapon collider after attack start.
        
    }
    public void AttackFlipAnimEvent(){
        slashAnim = Instantiate(slashAnimPreFab, slashAnimSpawnPoint.position, Quaternion.identity);
        slashAnim.transform.parent = this.transform.parent;
        if(playerController.FacingLeft){
            slashAnim.GetComponent<SpriteRenderer>().flipX = true;
        }
        else{
            slashAnim.GetComponent<SpriteRenderer>().flipX = false;
        }
        
    }

  

}
