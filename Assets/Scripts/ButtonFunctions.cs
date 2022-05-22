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

    public void WrongAnswerDelay()
    {

        if (SceneManager.GetActiveScene().buildIndex == 8) // Option 1 scene
            Invoke("WrongAnswerOption1", 1f);
        if (SceneManager.GetActiveScene().buildIndex == 9) // Option 2 scene
            Invoke("WrongAnswerOption2", 1f);
        if (SceneManager.GetActiveScene().buildIndex == 10) // Option 3 scene
            Invoke("WrongAnswerOption3", 1f);
    }
    public void WrongAnswerOption1()
    {
        PersistentData.Instance.SetScore(0);
        SceneManager.LoadScene("level1");

    }
    public void WrongAnswerOption2()
    {
        PersistentData.Instance.SetScore(5);
        SceneManager.LoadScene("level2");

    }
    public void WrongAnswerOption3()
    {
        PersistentData.Instance.SetScore(10);
        SceneManager.LoadScene("level3");

    }
    public void WrongAnswerOption4()
    {
        SceneManager.LoadScene("WrongAnswer");

    }
    public void WrongAnswerOption5()
    {
        SceneManager.LoadScene("WrongAnswer");

    }
    public void TryAgain()
    {
        PersistentData.Instance.SetScore(0);
        SceneManager.LoadScene("level1");

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
