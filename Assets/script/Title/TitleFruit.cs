using UnityEngine;


public class TitleFruit : MonoBehaviour
{
    public GameObject[] fruit = new GameObject[10];
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 0; i <= 40; ++i)
        {
            Instantiate(fruit[Random.Range(0,10)], this.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
