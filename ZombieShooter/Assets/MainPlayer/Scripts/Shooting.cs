using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform Cam;
    RaycastHit SmackInfo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Physics.Raycast(Cam.position,Cam.forward,out SmackInfo);
        
        if (Input.GetKeyDown("mouse 0"))
        {
            SmackInfo.collider.gameObject.GetComponent<EnemyHealth>().TakeDamage(25);
        }
    }
}
