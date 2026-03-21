using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Item
{
    public override void ApplyItem()
    {
        DestroyThis();
    }

    public override void DestroyAfterTime()
    {
        //Destroy(gameObject, 5f);
        Invoke("DestroyThis", 5f);
    }

    void DestroyThis()
    {
        Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ApplyItem();
        }
    }

}
