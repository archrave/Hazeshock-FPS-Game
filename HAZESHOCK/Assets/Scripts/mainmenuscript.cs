using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenuscript : MonoBehaviour
{
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
}
