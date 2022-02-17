using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int Health = 100;
    public GameObject DeathEffect;
    public GameObject BloodSplat;

    public void TakeDamage(int Damage)
    {
        Health -= Damage;
        
        if (Health <= 50)
        {
            BloodSplat.SetActive(true);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        BloodSplat.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Health);
        Death();
    }

    void Death()
    {
        if (Health == 0)
        {
            
            Destroy(gameObject);
            Instantiate(DeathEffect, transform.position + new Vector3(0, 0.4f, 0),Quaternion.identity);
            //Debug.Log("Death");
        }
    }
}
