using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    // Camera Object
    public GameObject player;
    private Vector3 offset = new Vector3(-0.06f, 5.32f, -11.46f);
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Following the Player
        transform.position = player.transform.position + offset;
        transform.rotation = player.transform.rotation;
    }
}
