using UnityEngine;
using UnityEngine.UI;

public class updatescore : MonoBehaviour
{
    public Text score;
    public Text highscore;

    public float score_count = 0f;
    private void Start()
    {
        highscore.text = PlayerPrefs.GetFloat("HighScore", 0f).ToString();
    }
    public void ChangeScore()
    {
        score_count++;
        score.text = score_count.ToString();
    }
    public void UpdateHighScore()
    {
        if (score_count > PlayerPrefs.GetFloat("HighScore", 0f))
        { 
            PlayerPrefs.SetFloat("HighScore", score_count);
            highscore.text = score_count.ToString();
        }
    }
}
