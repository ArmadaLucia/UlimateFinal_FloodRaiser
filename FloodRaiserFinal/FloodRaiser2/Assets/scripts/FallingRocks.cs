using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingRocks : MonoBehaviour
{
    public Rigidbody[] rocks;


    void OnTriggerEnter(Collider trig)
    {
        Debug.Log(trig.name);
        if (trig.CompareTag("Player"))
        {
          for (int i = 0; i < rocks.Length; i++)
            {
                rocks[i].useGravity = true;
            }
          

        }
    }
}