using UnityEngine;
using UnityEngine.SceneManagement;

public class pausescript : MonoBehaviour
{
    bool IsPaused = false;
    public GameObject pausemenuUI;
    /*void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }*/


    private void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused)
            {

                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }
    public void PauseGame()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        pausemenuUI.SetActive(true);
        Time.timeScale = 0f;
        IsPaused = true;
    }
    public void ResumeGame()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        pausemenuUI.SetActive(false);
        Time.timeScale = 1f;
        IsPaused = false;
    }
    public void GotoMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void ExitGame()
    {
        Debug.Log("Game is Quit from pause menu!");
        Application.Quit();
    }
}
