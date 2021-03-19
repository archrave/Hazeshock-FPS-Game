using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class findplayer : MonoBehaviour
{
    #region Singleton
    public static findplayer instance;
    void Awake()
    {
        instance = this;
    }
    #endregion

    public GameObject playerhaha ;
}
