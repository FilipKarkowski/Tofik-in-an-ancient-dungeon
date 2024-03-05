using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Debug = UnityEngine.Debug;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
[SerializeField] private int maximumPlayerHealth = 3;
[SerializeField] private int defence;


private int currentHealth;


private void Start() {
    currentHealth = maximumPlayerHealth;
}

public void TakeDamage(int damageAmount){
    
    currentHealth -= (damageAmount-defence);
    
    if(currentHealth <= 0){
        Debug.Log("Player was killed");    

        Destroy(gameObject);
        
       
    }
Debug.Log("Damage was taken, current health ="+currentHealth);    
}

}
