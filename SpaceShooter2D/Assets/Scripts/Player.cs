using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    private Transform tr;
    public float moveSpeed = 10.0f;
    private Animator anim;
    public Action levelUp;
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        //카메라뷰로 이동제한
        Vector3 worldPos = Camera.main.WorldToViewportPoint(this.transform.position);
        if (worldPos.x < 0.1f) worldPos.x = 0.1f;
        if (worldPos.x > 0.9f) worldPos.x = 0.9f;
        if (worldPos.y < 0.08f) worldPos.y = 0.08f;
        if (worldPos.y > 0.92f) worldPos.y = 0.92f;
        this.transform.position = Camera.main.ViewportToWorldPoint(worldPos);

        //이동
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector2 moveDir = new Vector2(h, v);
        Vector2 dir = moveDir.normalized;
        tr.Translate(dir * moveSpeed * Time.deltaTime);

        if (h > 0)
        {
            this.anim.SetInteger("State", 2);
        }
        else if (h < 0)
        {
            this.anim.SetInteger("State", 1);
        }
        else
        {
            this.anim.SetInteger("State", 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Boom")
        {
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "Coin")
        {
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "Power")
        {
            levelUp();
            Destroy(collision.gameObject);
        }
    }
}
