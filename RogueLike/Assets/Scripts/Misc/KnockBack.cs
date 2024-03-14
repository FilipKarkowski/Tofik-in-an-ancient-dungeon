using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class KnockBack : MonoBehaviour
{
    public bool gettingKnockedBack {get; private set;}

    [SerializeField] private float knockbacktime = 0.1F; // Set time how long object will bein in knockeffect.
    private Rigidbody2D rb;

    private void Awake() {
        rb = GetComponent<Rigidbody2D>(); //Getting the object rigidbody2D. 
    }

    public void GetKnockedBack(Transform damageSource, float knocBackThrust){
        gettingKnockedBack = true; //Set object flag to the gettingknockedback 
        StartCoroutine(KnockbackRoutine()); // starting coroutine
        Vector2 diffrence = (transform.position - damageSource.position).normalized * knocBackThrust * rb.mass; // calculate the recoil force to be applied to an object 
        rb.AddForce(diffrence,ForceMode2D.Impulse); // using rigidbody2D we adding some force to the object after 

    }

    private IEnumerator KnockbackRoutine(){ 
        // Method for turning off kockback effect after custom time amount
        yield return new WaitForSeconds(knockbacktime);
        rb.velocity = Vector2.zero; // change object velocity to 0 
        gettingKnockedBack = false; // Set object gettingknockedback flag to the false;
    }
}
