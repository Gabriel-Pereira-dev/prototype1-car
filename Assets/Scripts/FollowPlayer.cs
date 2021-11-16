using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    // Camera Object
    public GameObject player;
    private Vector3 offset;
    private string cameraType = "Default";
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Following the Player
        if (Input.GetKeyDown(KeyCode.C))
        {
            cameraType = cameraType == "Default" ? "First Person" : "Default";
        }
        if (cameraType != "Default")
            {
                offset = new Vector3(-0.15f, 4.44f, 1.15f);
            }
            else
            {
            offset = new Vector3(-0.06f, 5.32f, -11.46f);
            }
        
        transform.position = player.transform.position + offset;
    }
}
