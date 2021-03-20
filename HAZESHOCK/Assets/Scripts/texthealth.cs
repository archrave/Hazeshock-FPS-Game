using UnityEngine;
using UnityEngine.UI;

public class texthealth : MonoBehaviour
{
    public float maxhealthtext;
    public Text text_health;
    public void SetMaximumHealth(float health)
    {
        maxhealthtext = health;
    }

    public void ChangeTextHealth (float healthamount)
    {
        text_health.text = healthamount.ToString("0");
    }

}
