using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float maxHealth;
    public float health;
    private Animator animator;

    private bool isDead;
    private bool canTakeDamage = true;
    
    public GameManagerScript gameManager;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInParent<Animator>();
        health = maxHealth;
    }

     void Update()
    {
        if (health <= 0 && !isDead)
        {
            isDead =true;
            gameManager.gameOver();
            Debug.Log("dead");
            //GameOver();
        }
    }

     void GameOver()
    {
        
    }

    public void TakeDamage(float damage)
    {
        if (!canTakeDamage){return;}
        health -= damage;
        animator.SetBool("Damage",true);
        Debug.Log("Player health"+health);
        if (health <= 0)
        {
            GetComponentInParent<GetherInput>().OnDisable();
            Debug.Log("Player is dead");
        }
        StartCoroutine(DamagePrevention());
    }
   private IEnumerator DamagePrevention(){
    canTakeDamage = false;
    yield return new WaitForSeconds(0.15f);

    if (health >0)
    {
        
        canTakeDamage = true;
        animator.SetBool("Damage",false);
        
    }
    else {
        animator.SetBool("Dead",true);
    
    }
   }
}
