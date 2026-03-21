using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float health = 50f;
    public float speed;


    public float Health
    {
        get { return health; }
    }

    void TakeDamage(int value)
    {
        health -= value;
        if(health <= 0)
        {
            Die();
        }

        Debug.Log(health);
    }

    void TakeDamageByRatio(float ratio) //0.1
    {
        health -= (int)(health * ratio); // 50 * 0.1 -> 5 > 50-55 = 45; 
        if (health <= 0)
        {
            Die();
        }
    }

    public float GetHealth()
    {
        return health;
    }

 
    void Die()
    {
       Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("충돌");

        if (collision.gameObject.CompareTag("Bullet"))
        {
            TakeDamage(10);
            collision.gameObject.SetActive(false);
        }
    }

    public virtual void Move() //virtual > 오버라이드 가능
    {

    }



}
