using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] InputField playerNameInput;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayGame()
    {
        string s = playerNameInput.text;
        PersistentData.Instance.SetName(s);
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
    public void Settings()
    {
        SceneManager.LoadScene("Settings");

    }
    public void WrongAnswer()
    {
        SceneManager.LoadScene("WrongAnswer");

    }
    public void TryAgain()
    {
        PersistentData.Instance.SetScore(0);
        SceneManager.LoadScene("level1");
        PersistentData.Instance.SetScore(0);

    }
    public void QuestionOneCorrect()
    {
        SceneManager.LoadScene("level2");
    }
    public void QuestionTwoCorrect()
    {
        SceneManager.LoadScene("level3");
    }
    public void HighScores()

    {
        SceneManager.LoadScene(12);
    }

}
