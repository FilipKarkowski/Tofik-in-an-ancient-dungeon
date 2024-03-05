using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    // Start is called before the first frame updat
    [SerializeField] private int startingHealth = 3;

    SpriteRenderer spriteRenderer;
    private bool isDamaged = false;

    private int currentHealth;

    private void Start() {
        spriteRenderer = GetComponentInParent<SpriteRenderer>();
         currentHealth = startingHealth;
         
    }

    private void Update() {
        if(isDamaged){
        StartCoroutine(GotDamageIndicator());
        }
    }
    private IEnumerator GotDamageIndicator()
    {
        spriteRenderer.color = Color.red;
        Debug.Log("Damage effect activated");
       yield return new WaitForSeconds(0.2f);
       spriteRenderer.color = Color.white;
       isDamaged=false;

    }
    public void TakeDamage(int DamageSource){
        currentHealth -= DamageSource;
        isDamaged = true;
        Debug.Log(gameObject.name+" took damage " + "Current health:"+currentHealth);
        if(currentHealth <= 0){
            Destroy(gameObject);
            Debug.Log(gameObject.name+" was killed");
        }
        Debug.Log(currentHealth);
    }

    
}
