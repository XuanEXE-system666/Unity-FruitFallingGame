using UnityEngine;

public class FruitFalling : MonoBehaviour
{
    float LTime = 5f;
    public GameObject[] fruit = new GameObject[10];
    Vector3 ShengCheng;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LTime += Time.deltaTime;
        if(LTime >= 5.0f)
        {
            LTime = 0f;
            ShengCheng = new Vector3(Random.Range(-33, 33), 25, Random.Range(-33, 33));
            Instantiate(fruit[Random.Range(0, 10)], ShengCheng, this.transform.rotation);
        }
    }
}
