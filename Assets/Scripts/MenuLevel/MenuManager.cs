using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private GameObject menuPanel;
    
    void Start()
    {
        menuPanel.GetComponent<CanvasGroup>().DOFade(1,1f);
        menuPanel.GetComponent<RectTransform>().DOScale(1,1f).SetEase(Ease.OutBack);
    }

    public void SecondLevelUnlock()
    {
        SceneManager.LoadScene("secondMenuLevel");
    }

    public void MakeSettings()
    {

    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
