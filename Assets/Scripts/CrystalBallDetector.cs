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
            ExitLight.GetComponent<Lighton>().TurnOn();
            GameObject.FindGameObjectWithTag("Exit").gameObject.GetComponent<OpenExit>().clearRoom(7);
        }
    }

    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        collisionCount++;
    }
    private void OnTriggerExit(UnityEngine.Collider other)
    {
        collisionCount--;
    }
}
