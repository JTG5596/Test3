using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : Item
{
    public override void ApplyItem()
    {
        GameObject playerObj = GameObject.Find("Player");

        PlayerController Controller = playerObj.GetComponent<PlayerController>();
        Controller.moveSpeed *= 1.25f;
        //GameObject.Find("Player").GetComponent<PlayerController>().moveSpeed *= 1.25f;

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
