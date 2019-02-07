using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public float MaxHealth;
    public float CurrentHealth;


    // Use this for initialization
    void Start()
    {


    }

    public void Death()

    {
        Destroy(gameObject);

    }

    public void TakeDamage(float DamageAmount)
    {
        CurrentHealth = MaxHealth;
        CurrentHealth -= DamageAmount;

        if (CurrentHealth <= 0)
        { Death();
        }
    }
    // Update is called once per frame
    


}

