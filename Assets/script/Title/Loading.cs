using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public bool IsLoading = false;
    public int LoadingIndex;
    public GameObject MainCanva;
    public GameObject LoadingCanva;
    public Slider slider;
    void Update()
    {
        if (IsLoading)
        {
            IsLoading = false;
            MainCanva.SetActive(false);
            LoadingCanva.SetActive(true);
            StartCoroutine(ChangeSceneAsync());
        }
    }

    IEnumerator ChangeSceneAsync()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(LoadingIndex);
        while(!operation.isDone)
        {
            slider.value = operation.progress;
            yield return null;
        }
    }
}
