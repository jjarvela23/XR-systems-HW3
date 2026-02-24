using UnityEngine;

public class SecretBulb : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private GameObject otherbulb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        gameObject.GetComponent<Lighton>().TurnOn();
        otherbulb.GetComponent<Lighton>().TurnOn();
        GameObject.FindGameObjectWithTag("Exit").gameObject.GetComponent<OpenExit>().clearRoom(6);
    }
}
