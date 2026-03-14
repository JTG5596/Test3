using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float health = 100f;

    public float Health
    {
        get { return health; }
    }

    void TakeDamage(int value)
    {
        health -= value;
        if (health <= 0)
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
        if (collision.gameObject.tag == "Enemy")
        {
            TakeDamage(10);
            Destroy(collision.gameObject);
        }

        //collision.gameObject.CompareTag("Enemy");

        

    }

}
