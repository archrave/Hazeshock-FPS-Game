using UnityEngine;
using UnityEngine.UI;

public class updatehealth : MonoBehaviour
{
    public Slider healthbar;
    public float maxhealth;

    public void SetMaxHealth(float health)
    {
        healthbar.maxValue = health;
        healthbar.value = health;
    }

    public void HealthSlider(float health)
    {
        healthbar.value = health;
    }
}
