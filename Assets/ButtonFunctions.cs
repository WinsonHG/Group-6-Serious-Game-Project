using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayGame()
    {
        SceneManager.LoadScene("level1");
    }
    public void PlayGame2()
    {
        SceneManager.LoadScene("level2");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }
    public void backGround()
    {
        SceneManager.LoadScene("backGround");
    }
    public void funFact()
    {
        SceneManager.LoadScene("funFact");
    }

}
