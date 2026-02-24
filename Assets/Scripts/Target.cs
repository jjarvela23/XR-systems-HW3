using UnityEngine;

public class Target : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private GameObject RoomLight;
    [SerializeField] private GameObject ExitLight;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        RoomLight.GetComponent<Lighton>().TurnOn();
        ExitLight.GetComponent<Lighton>().TurnOn();
        GameObject.FindGameObjectWithTag("Exit").gameObject.GetComponent<OpenExit>().clearRoom(1);
    }
}
