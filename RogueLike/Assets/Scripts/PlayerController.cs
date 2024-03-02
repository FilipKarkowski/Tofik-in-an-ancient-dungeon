using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;
    private PlayerControls playerControls;
    private Vector2 movement;
    private Rigidbody2D rb;
    private Animator myAnimator;
    private SpriteRenderer mySpriteRenderer;

    private void Awake(){
        playerControls = new PlayerControls();
        rb = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Update() {
        PlayerInput();
    }
    private void FixedUpdate() {
        AdjustPlayerFacingDirection();
        Move();
    }


    private void PlayerInput()
    {
        
        movement = playerControls.Movement.Move.ReadValue<Vector2>();
        myAnimator.SetFloat("moveX",movement.x);
        myAnimator.SetFloat("moveY",movement.y);
        Debug.Log(movement.x);
    }    

    private void Move(){
        rb.MovePosition(rb.position + movement * (moveSpeed * Time.fixedDeltaTime));
    }

    private void AdjustPlayerFacingDirection(){
        Vector3 mousepos = Input.mousePosition;
        Vector3 playerScreenPoint = Camera.main.WorldToScreenPoint(transform.position);
        if(mousepos.x < playerScreenPoint.x){
           mySpriteRenderer.flipX = false;
            Debug.Log("nah");
        }
        else{
           
              mySpriteRenderer.flipX = true;
            Debug.Log("flipped");
        }
    }

    private void OnEnable() {
        playerControls.Enable();
    }
    // private void OnDisable() {
    //     playerControls.Disable();
    // }
}
