using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class LocomotionController : MonoBehaviour

{
    public XRController leftTeleportRay;
    public InputHelpers.Button teleportActivationButton;
    public float activationThreshold = 0.001f;
    private XRRayInteractor leftRayInteractor; 
    private void Start()
    {
       
        if (leftTeleportRay) 
             leftRayInteractor = leftTeleportRay.gameObject.GetComponent<XRRayInteractor>(); 
    }
    
    // Update is called once per frame
    void Update()
    {
        if (leftTeleportRay)
        {
            leftRayInteractor.allowSelect = CheckIfActivated(leftTeleportRay); 
            leftTeleportRay.gameObject.SetActive(CheckIfActivated(leftTeleportRay));
        }
        
    }
    public bool CheckIfActivated(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, teleportActivationButton, out bool isActivated, activationThreshold);
        return isActivated;
    }
}