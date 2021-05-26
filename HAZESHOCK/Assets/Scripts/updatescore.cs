using UnityEngine;
using UnityEngine.UI;

public class updatescore : MonoBehaviour
{
    public Text score;
    public Text highscore;
    public Text highscore2;

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
            highscore.text = score_count.ToString();
            highscore2.text = score_count.ToString();
            PlayerPrefs.SetFloat("HighScore", score_count);
        }
        else
        {
            highscore.text = PlayerPrefs.GetFloat("HighScore").ToString();
            highscore2.text = PlayerPrefs.GetFloat("HighScore").ToString();
        }
    }
}
