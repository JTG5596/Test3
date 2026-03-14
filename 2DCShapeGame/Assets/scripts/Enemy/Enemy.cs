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
        Debug.Log("Ãæµ¹");

        if (collision.gameObject.CompareTag("Bullet"))
        {
            TakeDamage(10);
            collision.gameObject.SetActive(false);
        }
    }
}
