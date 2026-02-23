using UnityEngine;

public class Chesttrigger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody.CompareTag("TheKey"))
        {
            gameObject.GetComponent<Animation>().Play();
        }
    }
}
