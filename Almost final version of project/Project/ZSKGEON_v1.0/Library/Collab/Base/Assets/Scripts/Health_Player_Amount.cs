﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_Player_Amount : MonoBehaviour
{
    public int MaxHealth = 5;
    public int CurrentHealth;
    public static bool GetDamage;


    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {


        if (CurrentHealth == -1)
        {
            CurrentHealth = 0;
        }


    }
    public void damage(int damageToDeal)
    {
        Debug.Log("dotknięto");
        CurrentHealth -= damageToDeal;
      }


}
