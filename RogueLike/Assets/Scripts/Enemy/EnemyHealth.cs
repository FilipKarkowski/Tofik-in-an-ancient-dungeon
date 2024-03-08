using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    // Start is called before the first frame updat
    [SerializeField] private int startingHealth = 3;
    [SerializeField] private float knockforce =5f;

    private SpriteRenderer spriteRenderer;
    private KnockBack knockBack;

    private bool isDamaged = false;


    private int currentHealth;

    private void Awake() {
        knockBack = GetComponent<KnockBack>();
    }
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
        knockBack.GetKnockedBack(PlayerController.Instance.transform, knockforce);
        Debug.Log(gameObject.name+" took damage " + "Current health:"+currentHealth);
        if(currentHealth <= 0){
            Destroy(gameObject);
            Debug.Log(gameObject.name+" was killed");
        }
        Debug.Log(currentHealth);
    }

    
}
