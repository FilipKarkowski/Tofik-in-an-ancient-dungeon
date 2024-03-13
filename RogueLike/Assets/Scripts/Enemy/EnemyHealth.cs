using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    // Start is called before the first frame updat
    [SerializeField] private int startingHealth = 3;    // Starting health 
    [SerializeField] private float knockforce = 5f; // Force that enemy will get after getting hitted 

    private SpriteRenderer spriteRenderer;
    private KnockBack knockBack;

    private bool isDamaged = false; 

    private int currentHealth;

    private void Awake() {
        knockBack = GetComponent<KnockBack>();
    }
    private void Start() {
        spriteRenderer = GetComponentInParent<SpriteRenderer>(); // Getting the enemy sprite renderer from main parent object
        currentHealth = startingHealth; // Setting current health to the max health
         
    }

    private void Update() {
        if(isDamaged){
        StartCoroutine(GotDamageIndicator()); // if isdamaged start coroutine for changing color or add affects/animation.
        }
    }
    private IEnumerator GotDamageIndicator()
    {
        /*
        Setting player damage indicator, changing color, can be changed for some animation event in the future. 

        */
        spriteRenderer.color = Color.red; // change enemy color after got hitted
    
        yield return new WaitForSeconds(0.2f);
        
        spriteRenderer.color = Color.white;
        isDamaged=false;

    }
    public void TakeDamage(int DamageSource){
        currentHealth -= DamageSource; // take damage amount from the current health points.
        isDamaged = true; // sett object flag to the damaged
        knockBack.GetKnockedBack(PlayerController.Instance.transform, knockforce); 
        if(currentHealth <= 0){
            Destroy(gameObject);
        }
    }

}
