using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed =1f;
    [SerializeField]
    private GameObject BulletPrefab; //프리팹 변수 선언

    [SerializeField]
    private float bulletSpeed;


    //public Vector2 pos;
    private void Awake()
    {
        //moveSpeed = 1f;
    }


    // Start is called before the first frame update
    void Start()
    {
        //gameObject.SetActive(false);
        //transform.position = new Vector2(0f, 5f);
        //Vector2 pos = new Vector2(0, 5f);
        //transform.position = pos;
        //Vector2 newPos = transform.position;
        //newPos.y = newPos.y + 5f;
       // newPos.y += 5f;

        //transform.position = newPos; //new Vector2(0f, 5f);
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, moveSpeed * Time.deltaTime, 0f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, -moveSpeed * Time.deltaTime, 0f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-moveSpeed * Time.deltaTime, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(moveSpeed * Time.deltaTime,0f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //GameObject Bullet = 
               // Instantiate(BulletPrefab, transform.position, Quaternion.identity);
            for(int i = 0; i<3; i++)
            {
                GameObject Bullet = Instantiate(BulletPrefab);

                Vector3 bulletPos = transform.position;

                bulletPos.y = bulletPos.y + 
                     1f*(i);

                Bullet.transform.position = bulletPos;



                Bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bulletSpeed);
            }
           
          
            // Bullet.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }
}
