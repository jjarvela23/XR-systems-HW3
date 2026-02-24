using UnityEngine;

public class ResetBall : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Vector3 startPosition;
    private Quaternion startRotation;

    void Start()
    {
        startPosition = transform.position;
        startRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetMe()
    {
        Instantiate(gameObject, position: startPosition, startRotation);
    }
}
