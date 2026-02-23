using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class HandController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private InputActionReference gripReference;

    [SerializeField] private InputActionReference triggerReference;
    [SerializeField] private Animator handAnimator;    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float gripValue = gripReference.action.ReadValue<float>();
        Debug.Log(gripValue);
        handAnimator.SetFloat("Grip", gripValue);


        float triggerValue = triggerReference.action.ReadValue<float>();
        Debug.Log(triggerValue);
        handAnimator.SetFloat("Trigger", triggerValue);
    }
}
