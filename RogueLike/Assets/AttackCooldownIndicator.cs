using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class AttackCooldownIndicator : MonoBehaviour
{
	private float weaponCooldown = 0f;
	private bool isCounting = false;
	private Text count;
	[SerializeField] Image cooldownbar;
	
	[SerializeField] private Slider slider;
	
	ActiveWeapon activeWeapon;

	private void Start()
	{
		activeWeapon = FindFirstObjectByType<ActiveWeapon>();
		count = GetComponent<Text>(); 
	}

   
	public void StartCounting(float weapCooldown)
	{
		slider.maxValue = weapCooldown;
		slider.value = slider.maxValue;
		cooldownbar.color = Color.red;
		if (!isCounting && activeWeapon.weapon.canattack) 
		{
			weaponCooldown = weapCooldown;
			isCounting = true;
			count.enabled = true; 
			UpdateCountdownText(); 
			InvokeRepeating("UpdateCountdown", 1f, 1f); 
		}
	}

	
	private void UpdateCountdown()
	{
		if (weaponCooldown > 0)
		{
			slider.value = weaponCooldown;
			weaponCooldown -= 1f; 
			UpdateCountdownText();
		}
		else
		{
			slider.value=0;
			FinishCounting();
		}
	}


	private void FinishCounting()
	{
		isCounting = false; 
		CancelInvoke("UpdateCountdown"); 
		count.enabled = false; 
		Debug.Log("Counting finished."); 
		activeWeapon.weapon.canattack = true;
		cooldownbar.color = Color.white;
		slider.value=slider.maxValue;
	}

	// Metoda aktualizująca tekst odliczania
	private void UpdateCountdownText()
	{
		count.text = weaponCooldown.ToString("0"); // Aktualizuj tekst na podstawie pozostałego czasu odliczania
	}
}
