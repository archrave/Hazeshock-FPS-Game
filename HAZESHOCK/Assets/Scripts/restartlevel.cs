using UnityEngine;
using UnityEngine.SceneManagement;

public class restartlevel : MonoBehaviour
{
    public void RestartLevel()
    {
        //Invoke("Restart", delay);
        Debug.Log("Restarting..................");
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
