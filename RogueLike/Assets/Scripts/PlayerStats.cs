using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Debug = UnityEngine.Debug;
using UnityEngine.UI;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
[SerializeField] internal float maximumPlayerHealth = 9;
[SerializeField] internal float defence;
[SerializeField] internal float strength = 0.5f;
[SerializeField] internal float moveSpeed = 1f;

[SerializeField] private Slider slider;


private float currentHealth;


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
