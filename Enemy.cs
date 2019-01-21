﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

    public int health = 100;

    public GameObject deathEffect;
    public Slider healthBar;
    public GameManager mygamemanager;

    private void Update()
    {
        healthBar.value = health;
    }

    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die ()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        mygamemanager.Victory();
    }
    
}
