using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float health = 1004f;
        float poisonDamage = 125.5f;
        Debug.Log(health);
        health -= poisonDamage;
        Debug.Log(health);
        health -= poisonDamage;
        Debug.Log(health);
        health -= poisonDamage;
        Debug.Log(health);
        health -= poisonDamage;
        Debug.Log(health);
        health -= poisonDamage;
        Debug.Log(health);
        health -= poisonDamage;
        Debug.Log(health);
        health -= poisonDamage;
        Debug.Log(health);
        health -= poisonDamage;
        Debug.Log(health);
        print("Player has been unalived!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}