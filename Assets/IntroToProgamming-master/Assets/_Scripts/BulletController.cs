using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    
    public GameObject Owner;
    public float DamageValue = 1;

   public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject != Owner)
        {
            health tempHealth = other.GetComponent<health>(
          );
            if (tempHealth != null)
            {
                tempHealth.TakeDamage(DamageValue);
            }

            Destroy(gameObject);
        }
    }
}
