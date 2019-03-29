using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGame : MonoBehaviour
{
    public GameObject FinishUI;
    public Animator Crosshair;

    public GameManager gamemanager;

    public AudioClip WinEndTrigger;
    public AudioSource WinEndTriggerSource;

    public bool alreadyPlayed = false;


    void OnTriggerEnter(Collider trig)
    {
        if (trig.CompareTag("Player"))
        {
            if (!alreadyPlayed)
            { 
                gamemanager.CompleteGame();
                FinishUI.SetActive(true);
                Crosshair.Play("CrosshairGo");
                WinEndTriggerSource.PlayOneShot(WinEndTrigger, 1F);
                alreadyPlayed = true;
            }
        }
    }
}
