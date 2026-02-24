using System;
using UnityEngine;

public class OpenExit : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    int[] roomsCleared = {0,0,0,0,0,0,0,0};
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (roomsCleared[0] == 1 && roomsCleared[1] == 1 && roomsCleared[2] == 1 && roomsCleared[3] == 1 && roomsCleared[4] == 1
            && roomsCleared[5] == 1 && roomsCleared[6] == 1 && roomsCleared[7] == 1 && roomsCleared[8] == 1)
        {
            gameObject.SetActive(false);
        }
          
    }

    public void clearRoom(int n)
    {
        roomsCleared[n-1] = 1;
    }
}
