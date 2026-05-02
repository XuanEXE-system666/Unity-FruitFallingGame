using UnityEngine;
using UnityEngine.UI;

public class TextShow : MonoBehaviour
{
    public Text score;
    public Text lives;
    GameData gameData;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameData = GameObject.FindWithTag("score").GetComponent<GameData>();
    }

    // Update is called once per frame
    void Update()
    {
        int scoreUsing = gameData.score;
        score.text = "Score：" + scoreUsing.ToString();

        int LiveUsing = gameData.live;
        lives.text = LiveUsing.ToString();
    }
}
