using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSmack : MonoBehaviour
{
    public Transform Zombie;
    float TargetDistance;
    float CurrentDistance;
    public float SmackDistance;
    Transform PlayerPosition;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        CurrentDistance = Vector3.Distance(transform.position,Player.transform.position);
        
        //This determines at which point the player starts to take damage
        if (CurrentDistance <= SmackDistance)
        {
            Player.GetComponent<MainPlayerHealth>().PlayerHealth(25);
        }

    }
}
