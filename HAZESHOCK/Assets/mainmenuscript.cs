using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenuscript : MonoBehaviour
{
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
