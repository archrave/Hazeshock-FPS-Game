using UnityEngine;

public class unfreezetime : MonoBehaviour
{
  
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 1f;
    }


}
