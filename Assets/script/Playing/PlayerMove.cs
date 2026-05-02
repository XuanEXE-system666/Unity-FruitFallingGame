using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject Boom;
    GameData gameData;
    GameObject gamedataGet;
    Rigidbody rb;
    BoxCollider box;
    MeshRenderer mesh;
    public QuitEvent quit;
    public MeshRenderer mesh2;
    public MeshRenderer mesh3;
    public bool IsMove = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gamedataGet = GameObject.FindWithTag("score").gameObject;
        gameData = gamedataGet.GetComponent<GameData>();
        rb = gameObject.GetComponent<Rigidbody>();
        box = gameObject.GetComponent<BoxCollider>();
        mesh = gameObject.GetComponent<MeshRenderer>();
        gameData.live = 3;
        gameData.score = 0;
    }
    void FixedUpdate()
    {
        if (IsMove)
        {
            float horizontal = Input.GetAxis("Horizontal");
            float Vertical = Input.GetAxis("Vertical");
            gameObject.transform.Translate(new Vector3(0, 0, Vertical * 10 * Time.deltaTime));
            gameObject.transform.Rotate(0, horizontal * 30 * Time.deltaTime, 0);
        }
 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "FAndV")
        {
            Destroy(collision.gameObject);
            gameData.score += 10;
        }
        if (collision.gameObject.tag == "DIED")
        {
            --gameData.live;
            IsMove = false;
            rb.isKinematic = true;
            rb.detectCollisions = false;
            box.enabled = false;
            mesh.enabled = false;
            mesh2.enabled = false;
            mesh3.enabled = false;
            Instantiate(Boom, this.transform.position, this.transform.rotation);
            Invoke("Reborn", 3f);
        }
    }

    private void Reborn()
    {
        if (gameData.live > 0)
        {
            this.transform.position = new Vector3(0, 0.53f, 0);
            rb.isKinematic = false;
            rb.detectCollisions = true;
            box.enabled = true;
            mesh.enabled = true;
            mesh2.enabled = true;
            mesh3.enabled = true;
            IsMove = true;
        }
        else
            quit.QuitToTitle();
    }
}
