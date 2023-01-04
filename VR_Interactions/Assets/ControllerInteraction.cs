using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;


public class ControllerInteraction : MonoBehaviour
{
    // Start is called before the first frame update
    public SteamVR_Input_Sources handType;
    public SteamVR_Behaviour_Pose controllerPose;
    public SteamVR_Action_Boolean grabAction;

    private GameObject collidingObject; // 1
    private GameObject objectInHand; // 2

    private void SetCollidingObject(Collider col)
{
    // 1
    if (collidingObject || !col.GetComponent<Rigidbody>())
    {
        return;
    }
    // 2
    collidingObject = col.gameObject;
}

    // Update is called once per frame
    void Update()
    {
        
    }
}