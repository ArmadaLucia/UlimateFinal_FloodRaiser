using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class ReturnMenu : MonoBehaviour
{

    public void ReturntoMenu()
    {
        SceneManager.LoadScene("Menu");
        AudioListener.pause = true;
        FindObjectOfType<RigidbodyFirstPersonController>().mouseLook.SetCursorLock(false);
    }
}

