using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{

    public void PlayButtonPressed()
    {
        SceneManager.LoadScene("level1");
    }

}
