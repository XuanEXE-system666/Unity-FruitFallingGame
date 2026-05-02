using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class ButtonAndTextEvent : MonoBehaviour
{
    public Text BestFengbi;
    public Text BestKaiFang;
    public GameData gameData;
    public GameObject DeleteScore;
    public Loading loading;
    bool IsDeleteShow = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameData = GameObject.FindGameObjectWithTag("score").GetComponent<GameData>();
        BestFengbi.text = "封闭平台最高分：" + gameData.BestFengBi.ToString();
        BestKaiFang.text = "开放平台最高分：" + gameData.BestKaiFang.ToString();
    }
    public void GoKaiFang()
    {
        loading.LoadingIndex = 2;
        loading.IsLoading = true;
    }
    public void GoFengbi()
    {
        loading.LoadingIndex = 1;
        loading.IsLoading = true;
    }

    public void Clear()
    {
        PlayerPrefs.SetInt("Best_KaiFang", 0);
        PlayerPrefs.SetInt("Best_Fengbi", 0);
        gameData.RefreshScore();
        BestFengbi.text = "封闭平台最高分：" + gameData.BestFengBi.ToString();
        BestKaiFang.text = "开放平台最高分：" + gameData.BestKaiFang.ToString();
        CancelClear();
    }

    public void CancelClear()
    {
        DeleteScore.SetActive(IsDeleteShow);
        IsDeleteShow = !IsDeleteShow;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Delete))
        {
            DeleteScore.SetActive(IsDeleteShow);
            IsDeleteShow = !IsDeleteShow;
        }
    }
}
