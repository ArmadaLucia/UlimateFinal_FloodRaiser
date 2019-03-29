﻿using UnityEngine;

public class Flasher : MonoBehaviour {


    public GameObject Note;
    public GameObject PuzzleNote;
    public int redCol;
    public int greenCol;
    public int blueCol;
    public bool LookingAtObject = false;
    public bool flashingIn = true;
    public bool startedFlashing = false;

    private void Update()
    {
        if (LookingAtObject == true)
        {
            Note.GetComponent<Renderer>().material.color = new Color32((byte)redCol, (byte)greenCol, (byte)blueCol, 255);
            PuzzleNote.GetComponent<Renderer>().material.color = new Color32((byte)redCol, (byte)greenCol, (byte)blueCol, 255);
        }
    }

    void OnMouseOver()
    {
        LookingAtObject = true;
        if(startedFlashing == false)
        {
            startedFlashing = true;
        }
    }

    void OnMouseExit()
    {
        startedFlashing = false;
        LookingAtObject = false;
        Note.GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 255);
        PuzzleNote.GetComponent<Renderer>().material.color = new Color32((byte)redCol, (byte)greenCol, (byte)blueCol, 255);
    }

}
