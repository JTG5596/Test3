using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : Enemy
{



    public override void Move()
    {
        //리지드바디 사용(addforce), 오른쪽으로 이동
        GetComponent<Rigidbody2D>().AddForce(Vector3.left * speed);

    }
}
