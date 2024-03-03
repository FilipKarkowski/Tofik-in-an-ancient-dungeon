using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class Sword : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject slashAnimPreFab;
    [SerializeField] Transform slashAnimSpawnPoint;

    [SerializeField] private Transform weaponCollider;
    private PlayerControls playerControls;
    private Animator myAnimator;
    private PlayerController playerController;
    private ActiveWeapon activeWeapon;

    private GameObject slashAnim;
    private void Awake() {
        playerController = GetComponentInParent<PlayerController>();
        activeWeapon = GetComponentInParent<ActiveWeapon>();
        playerControls = new PlayerControls();
        myAnimator = GetComponent<Animator>();
    }
    void Start()
    {
       playerControls.Combat.Attack.started += _ => Attack();
    }
    private void OnEnable() {
        playerControls.Enable();
    }
    private void Update() {
        MouseFollowWithOffSet();
    }
    private void Attack(){
        myAnimator.SetTrigger("Attack");
        slashAnim = Instantiate(slashAnimPreFab, slashAnimSpawnPoint.position, Quaternion.identity);
        slashAnim.transform.parent = this.transform.parent;
        if(playerController.FacingLeft){
            slashAnim.GetComponent<SpriteRenderer>().flipX = true;
        }
        else{
            slashAnim.GetComponent<SpriteRenderer>().flipX = false;
        }
        
    }


    private void MouseFollowWithOffSet(){
        Vector3 mousepos = Input.mousePosition;
        Vector3 playerScreenPoint = Camera.main.WorldToScreenPoint(playerController.transform.position);

        float angle = Mathf.Atan2(mousepos.y, mousepos.x) * Mathf.Rad2Deg;

        if (mousepos.x < playerScreenPoint.x){
            activeWeapon.transform.rotation = Quaternion.Euler(0, -180, angle);
            weaponCollider.transform.rotation = Quaternion.Euler(0, -180, 0);

        }else {
            activeWeapon.transform.rotation = Quaternion.Euler(0,0,angle);
            weaponCollider.transform.rotation = Quaternion.Euler(0, -180, 0);
        }
    }
}
