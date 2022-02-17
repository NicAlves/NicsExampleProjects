using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    CharacterController CC;
    float YMove;
    Vector3 V3;
    public float ZombieSpeed = 5;
    public GameObject Player;
    public int DebugZombieDistance;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");

        CC = GetComponent<CharacterController>();
    }

    void Gravity()
    {


        if (CC.isGrounded == false)
        {
            YMove = YMove - 0.5f * Time.deltaTime;
        }
        else
        {
            YMove = 0;
        }


    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(CC);
        transform.LookAt(Player.transform.position);

        Gravity();

        if (DebugZombieDistance == 0)
        {
            Debug.Log(V3);
        }

        
    }

    private void FixedUpdate()
    {
        V3 = new Vector3(0,0,Time.deltaTime * ZombieSpeed);
        //transform.position += V3;

        CC.Move(transform.rotation * new Vector3(0, YMove, V3.z));

    }
}
