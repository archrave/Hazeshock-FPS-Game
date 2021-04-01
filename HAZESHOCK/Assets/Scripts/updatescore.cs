using UnityEngine;
using UnityEngine.UI;

public class updatescore : MonoBehaviour
{
    public Text score;
    public float score_count = 0f;
    public void ChangeScore()
    {
        score_count++;
        score.text = score_count.ToString();
    }

}
