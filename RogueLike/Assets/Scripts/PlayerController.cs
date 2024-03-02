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
    private void Awake(){
        playerControls = new PlayerControls();
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update() {
        PlayerInput();
    }
    private void FixedUpdate() {
        Move();
    }


    private void PlayerInput()
    {
        movement = playerControls.Movement.Move.ReadValue<Vector2>();
       
        Debug.Log(movement.x);
    }    
    private void Move(){
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    private void OnEnable() {
        playerControls.Enable();
    }
    // private void OnDisable() {
    //     playerControls.Disable();
    // }
}
