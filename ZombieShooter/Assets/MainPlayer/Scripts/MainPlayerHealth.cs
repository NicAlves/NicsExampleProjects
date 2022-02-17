using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayerHealth : MonoBehaviour
{
    int Health = 100;

    public void PlayerHealth (int Damage)
    {
        Health -= Damage;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
