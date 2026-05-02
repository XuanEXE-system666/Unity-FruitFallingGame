using UnityEngine;

public class BoomCube : MonoBehaviour
{
    public BoxCollider box;
    public Rigidbody rb;
    public bool f = false;

    void Start()
    {
        box = GetComponent<BoxCollider>();
        rb = GetComponent<Rigidbody>();
        Invoke("Canceled", 3.0f);
    }
    private void Canceled()
    {
        Destroy(box);
        Destroy(rb);
        rb = null;
        box = null;
    }
}

