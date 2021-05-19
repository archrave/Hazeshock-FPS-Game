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
        PlayerPrefs.DeleteKey("HighScore");
        Highscoreref.text = "0";
    }
}
