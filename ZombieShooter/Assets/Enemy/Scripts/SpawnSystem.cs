using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSystem : MonoBehaviour
{
    public GameObject ZombieWalker;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ZombieWalker, new Vector3(0, 3f, 4), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
