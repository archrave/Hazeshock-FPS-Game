using UnityEngine;
using UnityEngine.SceneManagement;

public class restartlevel : MonoBehaviour
{
    int isEnd = 0;

    public float delay = 2f;


    public void endgame()
    {
        if (isEnd == 0)
        {
            isEnd = 1;
            Debug.Log("Game Over");
            Invoke("Restart", delay);

        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
