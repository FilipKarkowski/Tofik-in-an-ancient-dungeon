using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EnemyHealthBar : MonoBehaviour
{
	// Start is called before the first frame update
	
	
	[SerializeField] Slider slider; // Init slider 
	 [SerializeField] EnemyHealth enemyHealth; // init enemy health 
	 [SerializeField] Text text;
	 
	 
	void Start()
	{
		slider.maxValue = enemyHealth.startingHealth;
	}
	
	private void Update() {
		EnemyhealthCheck();
	}
	
	private void EnemyhealthCheck()
	{
		if(enemyHealth.currentHealth > 0){
		slider.value = enemyHealth.currentHealth;
		text.text = enemyHealth.currentHealth.ToString();
		}
	}

}
