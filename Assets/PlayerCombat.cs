using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    private float timeBtwAttack;
    public float startTimeBtwAttack;
    public Animator animator;

    public Transform attackPos;
    public float attackRange;
    public LayerMask whatIsEnemies;
    public int damage;

    void Update()
    {

        if (timeBtwAttack <= 0)
        {
            timeBtwAttack = startTimeBtwAttack;
            if (Input.GetKey(KeyCode.Mouse0))
            {
                animator.SetTrigger("Attack");
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    //enemiesToDamage[i].GetComponent<Enemy>().health -= damage;
                }
            }
        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
        }
    }

    public void TakeDamage(int damage)
    {

    }
     

}
