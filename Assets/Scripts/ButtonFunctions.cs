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
        if (SceneManager.GetActiveScene().buildIndex == 10) // Option 1 scene
            Invoke("WrongAnswerOption1", 1f);
        if (SceneManager.GetActiveScene().buildIndex == 11) // Option 2 scene
            Invoke("WrongAnswerOption2", 1f);
        if (SceneManager.GetActiveScene().buildIndex == 12) // Option 4 scene
            Invoke("WrongAnswerOption3", 1f);
        if (SceneManager.GetActiveScene().buildIndex == 13) // Option 5 scene
            Invoke("WrongAnswerOption4", 1f);
        if (SceneManager.GetActiveScene().buildIndex == 14) // Option 6 scene
            Invoke("WrongAnswerOption5", 1f);
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
        PersistentData.Instance.SetScore(16);
        SceneManager.LoadScene("level4");

    }
    public void WrongAnswerOption5()
    {
        PersistentData.Instance.SetScore(20);
        SceneManager.LoadScene("level5");

    }

    public void RightAnswerDelay()
    {
        if (SceneManager.GetActiveScene().buildIndex == 10) // Level 1 scene
            Invoke("QuestionOneCorrect", 1f);
        if (SceneManager.GetActiveScene().buildIndex == 11) // Level 2 scene
            Invoke("QuestionTwoCorrect", 1f);
        if (SceneManager.GetActiveScene().buildIndex == 12) // Level 3 scene
            Invoke("QuestionThreeCorrect", 1f);
        if (SceneManager.GetActiveScene().buildIndex == 13) // Level 4 scene
            Invoke("QuestionFourCorrect", 1f);
        if (SceneManager.GetActiveScene().buildIndex == 14) // Level 5 scene
            Invoke("QuestionFiveCorrect", 1f);
    }
    public void QuestionOneCorrect()
    {
        SceneManager.LoadScene("level2");
    }
    public void QuestionTwoCorrect()
    {
        SceneManager.LoadScene("level3");
    }
    public void QuestionThreeCorrect()
    {
        SceneManager.LoadScene("level4");
    }
    public void QuestionFourCorrect()
    {
        SceneManager.LoadScene("level5");
    }
    public void QuestionFiveCorrect() // last question, move to end screen
    {
        SceneManager.LoadScene("EndScreen");
    }

    public void HighScores()

    {
        SceneManager.LoadScene("HighScores");
    }

}
