using UnityEngine;

public class BoomCenter : MonoBehaviour
{
    public SphereCollider box;
    public Rigidbody rb;
    void Start()
    {
        Invoke("Canceled", 1.0f);
    }

    private void Canceled()
    {
        Destroy(box);
        Destroy(rb);
        rb = null;
        box = null;
    }
}
