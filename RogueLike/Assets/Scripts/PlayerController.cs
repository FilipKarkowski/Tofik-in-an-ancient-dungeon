using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{

	//main player controller script 
	public static PlayerController Instance; // Geting current player object 
	public bool FacingLeft{ get {return facingLeft;} set {facingLeft = value;}} // Flag for check if player is facing left. 
	
	
	

	//player movement
	PlayerStats playerStats;
	private PlayerControls playerControls;
	private Vector2 movement;
	private Rigidbody2D rb;

	//Animation
	private Animator myAnimator;
	private SpriteRenderer mySpriteRenderer;
	private bool facingLeft = false;
	 

	private void Awake(){
		Instance = this; // set player instance

		//component getting
		playerControls = new PlayerControls(); 
		rb = GetComponent<Rigidbody2D>();
		myAnimator = GetComponent<Animator>();
		mySpriteRenderer = GetComponent<SpriteRenderer>();
		playerStats = GetComponent<PlayerStats>();
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
		movement = playerControls.Movement.Move.ReadValue<Vector2>(); // Reading player input calues
		myAnimator.SetFloat("moveX",movement.x);
		myAnimator.SetFloat("moveY",movement.y);
	}    

	private void Move(){
		rb.MovePosition(rb.position + movement * (playerStats.moveSpeed * Time.fixedDeltaTime)); //Player moving function
	}

	private void AdjustPlayerFacingDirection(){
		Vector3 mousepos = Input.mousePosition; // Getting player mouse position
		Vector3 playerScreenPoint = Camera.main.WorldToScreenPoint(transform.position); // Getting player position vector on the camera.
		
		if(mousepos.x < playerScreenPoint.x){
			mySpriteRenderer.flipX = true;
			FacingLeft = true;
		}
		else{
			 mySpriteRenderer.flipX = false;
			 FacingLeft = false;
		}
	}

	 private void OnEnable() {
		 playerControls.Enable();
	 }
	// private void OnDisable() {
	//     playerControls.Disable();
	// }
}
