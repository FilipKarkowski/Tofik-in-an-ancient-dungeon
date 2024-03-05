using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    // Start is called before the first frame updat
    [SerializeField] private int startingHealth = 3;

    private int currentHealth;

    private void Start() {
         currentHealth = startingHealth;
    }


    public void TakeDamage(int DamageSource){
        currentHealth -= DamageSource;
        Debug.Log(gameObject.name+" took damage " + "Current health:"+currentHealth);
        if(currentHealth <= 0){
            Destroy(gameObject);
            Debug.Log(gameObject.name+" was killed");
        }
        Debug.Log(currentHealth);
    }

    
}
