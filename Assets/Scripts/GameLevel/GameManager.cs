using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject baslaImage;

    void Start()
    {
        if (PlayerPrefs.HasKey("hangiOyun")) // anahtarı soruyor
        {
            //Debug.Log(PlayerPrefs.GetString("hangiOyun")); // playerprefs i cagiriyor
        }

        StartCoroutine(baslaYaziRoutine());
    }


    IEnumerator baslaYaziRoutine()
    {
        baslaImage.GetComponent<RectTransform>().DOScale(1.3f, 0.5f);
        yield return new WaitForSeconds(0.6f);
        baslaImage.GetComponent<RectTransform>().DOScale(0f, 0.5f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(0.6f);

        OyunaBasla();

    }

    void OyunaBasla()
    {
        Debug.Log("oyun basladi");
    }
}
