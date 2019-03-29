using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TsunamiTrigger : MonoBehaviour
{

    public GameObject Tsunami;
    public ConstantForce Water;

    public AudioClip ChasingSound;
    public AudioSource sound;

    public AudioClip BeachSound;
    public AudioSource introsound;

    public bool alreadyPlayed = false;

    void OnTriggerEnter(Collider trig)
    {
        if (trig.CompareTag("Player"))
        {
            if (!alreadyPlayed)
            {
                Debug.Log("Tsunami Triggered!");
                Tsunami.SetActive(true);

                Water.enabled = true;

                introsound.Stop();
                sound.clip = ChasingSound;
                sound.Play();
                alreadyPlayed = true;
            }
        }
    }
}