using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainmenuscript : MonoBehaviour
{
    public Text Highscoreref;
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Highscoreref.text = PlayerPrefs.GetFloat("HighScore").ToString();
    }

    public void PlayButtonClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitButtonClicked()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
    public void ResetHighScoreButtonClicked()
    {
        Debug.Log("Highscore is Reset");
        Highscoreref.text = "0";
        PlayerPrefs.DeleteAll();
    }

}
