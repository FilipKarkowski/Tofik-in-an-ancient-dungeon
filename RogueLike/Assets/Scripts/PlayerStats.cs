using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Debug = UnityEngine.Debug;
using UnityEngine.UI;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
[SerializeField] private int maximumPlayerHealth = 9;
[SerializeField] private int defence;
[SerializeField] private Slider slider;


private int currentHealth;


private void Start() {
    currentHealth = maximumPlayerHealth;
    slider.maxValue = maximumPlayerHealth;
    slider.value = currentHealth;
}

public void TakeDamage(int damageAmount){
    
    currentHealth -= (damageAmount-defence);
    slider.value = currentHealth;
    if(currentHealth <= 0){
        Debug.Log("Player was killed");    
     
        Destroy(gameObject);
        
       
    }
Debug.Log("Damage was taken, current health ="+currentHealth);    
}

}
