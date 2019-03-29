using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimDoor : MonoBehaviour
{

    public Animator anim;
    public ConstantForce Water;
    public GameObject colli;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("3"))
        {
            anim.Play("Deur");
            Debug.Log("YOU WIN!");
            colli.SetActive(false);
        }

        if (Input.GetKeyDown("4"))
        {
            Debug.Log("YOU LOSE!");

            Water.enabled = true;
            Rigidbody rigidbody = Water.GetComponent<Rigidbody>();

            rigidbody.velocity = Vector3.back;
            rigidbody.angularVelocity = Vector3.back;
        }
}
    }
