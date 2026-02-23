using UnityEngine;

public class LensCamera : MonoBehaviour
{
    public Transform lensCamera = null;
    public Transform mainCameraTransform = null;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //create instance of main camera
        GameObject mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        mainCameraTransform = mainCamera.transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //get coordínates of this camera, and coordinates of main camera
        //do math to get the angle.
        Vector3 direction = transform.position - mainCameraTransform.position;
        transform.rotation = Quaternion.LookRotation(direction);
    }
}
