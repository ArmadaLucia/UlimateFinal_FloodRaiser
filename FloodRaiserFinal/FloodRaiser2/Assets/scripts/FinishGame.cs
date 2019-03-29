using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGame : MonoBehaviour
{
    public GameObject FinishUI;
    public Animator Crosshair;

    public GameManager gamemanager;


    void OnTriggerEnter(Collider trig)
    {
        if (trig.CompareTag("Player"))
        {
            gamemanager.CompleteGame();
            FinishUI.SetActive(true);
            Crosshair.Play("CrosshairGo");
        }
    }
}
