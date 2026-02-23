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

    void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.attachedRigidbody.CompareTag("TheKey"))
        {
            gameObject.GetComponent<Animation>().Play();
        }
    }
}
