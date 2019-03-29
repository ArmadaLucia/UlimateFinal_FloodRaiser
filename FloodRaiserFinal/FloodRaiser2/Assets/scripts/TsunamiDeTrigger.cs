using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TsunamiDeTrigger : MonoBehaviour
{

    public GameObject Tsunami;
    public ConstantForce Water;

    void OnTriggerEnter(Collider trig)
    {
        if (trig.CompareTag("Player"))
        {
            Debug.Log("Tsunami GONE!");
            Tsunami.SetActive(false);

            Water.enabled = false;
            Rigidbody rigidbody = Water.GetComponent<Rigidbody>();

            rigidbody.velocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;

        }

        if (Input.GetKeyDown("4"))
        {
            Debug.Log("YOU LOSE!");

            Water.enabled = true;
        }
    }
}