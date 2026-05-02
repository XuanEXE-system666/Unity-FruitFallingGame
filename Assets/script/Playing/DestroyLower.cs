using UnityEngine;

public class DestroyLower : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnCollisionEnter(Collision collision)
    {
        string tag = collision.gameObject.tag; 
        if(tag == "FAndV" || tag == "DIED")
        {
            Destroy(collision.gameObject);
        }
    }
}
