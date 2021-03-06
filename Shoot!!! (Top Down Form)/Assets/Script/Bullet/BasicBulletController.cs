﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicBulletController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    public float speed;
    public Player1Controller player;
    public int jumpTime = 0;


    bool HitThewwall;

    void setBallDirection()
    {
        if (Mathf.Sqrt(Mathf.Pow(rigid2D.velocity.x, 2) + Mathf.Pow(rigid2D.velocity.y, 2)) < 5)
        {
            rigid2D.AddForce(player.gameObject.transform.up * speed);
            print(player.gameObject.transform.up);
        }
    }

    void Start ()
    {
        rigid2D = gameObject.GetComponent<Rigidbody2D>();
        GameObject Player = GameObject.Find("Player1");
        player = Player.GetComponent<Player1Controller>();
        setBallDirection();
    }
	

	void Update ()
    {
        setBallDirection();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player1")
        {
            Destroy(other.gameObject);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Basic Bullet"))
        {
            Destroy(this.gameObject);
        }
        else if (collision.collider.tag == "Player1")
        {
            Destroy(this.gameObject);
        }
        else if (collision.collider.tag == "Player")
        {
            Destroy(this.gameObject);
        }
        else if (collision.collider.tag == "ball")
        {
            Destroy(this.gameObject);
        }
        else if (collision.collider.tag == "bullet2")
        {
            Destroy(this.gameObject);
        }
        else if (collision.collider.tag == "bullet3")
        {
            Destroy(this.gameObject);
        }
        else if (collision.collider.tag == "Player3")
        {
            Destroy(this.gameObject);
        }
        else if (collision.collider.tag == "Player4")
        {
            Destroy(this.gameObject);
        }
        else if (collision.collider.tag == "bullet4")
        {
            Destroy(this.gameObject);
        }
        else if (collision.collider.tag == "Player2")
        {
            Destroy(this.gameObject);
        }
        else if(collision.collider.tag == "Wall")
        {
            Destroy(this.gameObject);
        }

    }
}
