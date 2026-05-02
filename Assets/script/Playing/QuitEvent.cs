using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitEvent : MonoBehaviour
{
    GameData gameData;
    public Loading loading;

    private void Start()
    {
        gameData = GameObject.FindWithTag("score").gameObject.GetComponent<GameData>();
    }
    public void QuitToTitle()
    {
        gameData = GameObject.FindWithTag("score").GetComponent<GameData>();
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            int Best = PlayerPrefs.GetInt("Best_FengBi");
            if (gameData.score >= Best)
                PlayerPrefs.SetInt("Best_FengBi", gameData.score);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            int Best = PlayerPrefs.GetInt("Best_KaiFang");
            if (gameData.score >= Best)
                PlayerPrefs.SetInt("Best_KaiFang", gameData.score);
        }
        PlayerPrefs.Save();
        gameData.RefreshScore();
        loading.LoadingIndex = 0;
        loading.IsLoading = true;
    }
}
