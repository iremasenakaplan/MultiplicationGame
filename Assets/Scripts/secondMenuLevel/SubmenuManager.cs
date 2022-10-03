using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SubmenuManager : MonoBehaviour
{
    
    void Start()
    {
        
    }
    
    public void HangiOyunAcilsin(string hangiOyun)
    {
      PlayerPrefs.SetString("hangiOyun", hangiOyun); //PlayerPrefs key created.
      SceneManager.LoadScene("GameLevel");
    }
   

    public void ReturnButton()
    {

     SceneManager.LoadScene("MenuLevel");

    }  



}
