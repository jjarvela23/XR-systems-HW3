using UnityEngine;

public class CrystalBallDetector : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int collisionCount = 0;
    [SerializeField] private GameObject RoomLight;
    [SerializeField] private GameObject ExitLight;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (collisionCount >= 10)
        {
            RoomLight.GetComponent<Lighton>().TurnOn();
        }
    }

    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        collisionCount++;
        Debug.Log(collisionCount);
    }
    private void OnTriggerExit(UnityEngine.Collider other)
    {
        collisionCount--;
        Debug.Log(collisionCount);
    }
}
