using UnityEngine;
using UnityEngine.SceneManagement;

public class GameData : MonoBehaviour
{
    public static bool IsLoad;
    public int score;
    public int live;
    public int BestKaiFang;
    public int BestFengBi;
    public int LastScene;

    void Awake()
    {
        if (IsLoad)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            RefreshScore();
            IsLoad = true;
        }
    }

    public void RefreshScore()
    {
        BestFengBi = PlayerPrefs.GetInt("Best_FengBi");
        BestKaiFang = PlayerPrefs.GetInt("Best_KaiFang");
    }
}

