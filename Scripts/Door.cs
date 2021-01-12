using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public bool isOpened = false;
    [Range(0.0f, 4.0f)]
    public float OpenSpeed = 3.0f;

    // Hinge
    Rigidbody rbDoor;
    HingeJoint hinge;
    JointLimits hingeLim;
    float currentLim;

    void Start() {
        rbDoor = GetComponent<Rigidbody>();
        hinge = GetComponent<HingeJoint>();
    }

    private void FixedUpdate() { // door is physical object
        if (isOpened) {
            currentLim = 85.0f;
        } 
        else {
            // currentLim = hinge.angle;  door will closed from current opened angle
            if (currentLim > 1.0f) 
                currentLim -= .5f * OpenSpeed;
            }
        
        // using values to door object
        hingeLim.max = currentLim;
        hingeLim.min = -currentLim;
        hinge.limits = hingeLim;
    }
}
