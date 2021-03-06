﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1HealthController : MonoBehaviour
{
    public float startingHealth;
    private float currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startingHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float enemyHit(float damage)
    {
        currentHealth -= damage;
        this.GetComponentInChildren<HealthBarScript>().scale(currentHealth);
        return currentHealth;
    }

    public float getStartingHealth()
    {
        return startingHealth;
    }
}
