using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    void Start()
    {
        if (PlayerPrefs.HasKey("hangiOyun")) // anahtarı soruyor
        {
            Debug.Log(PlayerPrefs.GetString("hangiOyun")); // playerprefs i cagiriyor
        }
    }

}
