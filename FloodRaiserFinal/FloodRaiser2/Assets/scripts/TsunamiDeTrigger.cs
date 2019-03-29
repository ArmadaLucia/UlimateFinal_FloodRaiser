using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TsunamiDeTrigger : MonoBehaviour
{

    public GameObject Tsunami;
    public ConstantForce Water;

    public AudioClip ChasingSound;
    public AudioSource sound;

    public AudioClip EndChaseSound;
    public AudioSource exsound;

    public AudioClip DeathPuzzle;
    public AudioSource DeathPuzzleSource;

    public bool alreadyPlayed = false;

    void OnTriggerEnter(Collider trig)
    {
        if (trig.CompareTag("Player"))
        {
            if (!alreadyPlayed)
            {
                Debug.Log("Tsunami GONE!");
                Tsunami.SetActive(false);

                sound.Stop();
                exsound.clip = EndChaseSound;
                exsound.Play();

                Water.enabled = false;
                Rigidbody rigidbody = Water.GetComponent<Rigidbody>();

                rigidbody.velocity = Vector3.zero;
                rigidbody.angularVelocity = Vector3.zero;
                alreadyPlayed = true;
            }

        }

        if (Input.GetKeyDown("4"))
        {
            Debug.Log("YOU LOSE!");

            Water.enabled = true;
            DeathPuzzleSource.PlayOneShot(DeathPuzzle, 1F);
        }
}
}