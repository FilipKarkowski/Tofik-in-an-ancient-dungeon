using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class KnockBack : MonoBehaviour
{
    public bool gettingKnockedBack {get; private set;}
    private Rigidbody2D rb;

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    public void GetKnockedBack(Transform damageSource, float knocBackThrust){
        gettingKnockedBack = true;
        StartCoroutine(KnockbackRoutine());
        Vector2 diffrence = (transform.position - damageSource.position).normalized * knocBackThrust * rb.mass;
        rb.AddForce(diffrence,ForceMode2D.Impulse);

    }

    private IEnumerator KnockbackRoutine(){
        yield return new WaitForSeconds(0.1F);
        rb.velocity = Vector2.zero;
        gettingKnockedBack = false;
    }
}
