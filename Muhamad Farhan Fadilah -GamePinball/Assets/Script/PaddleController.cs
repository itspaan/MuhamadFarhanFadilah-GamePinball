using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public KeyCode input;


    private float targetPresed;
    private float targetRelease;
    private HingeJoint hinge;


    private void Start()
    {
        hinge = GetComponent<HingeJoint>();

        targetPresed = hinge.limits.max;
        targetRelease = hinge.limits.min;
    }

    // Update is called once per frame
    private void Update()
    {
        ReadInput();
    }

    private void ReadInput()
    {
        JointSpring jointSpring = hinge.spring;

        if (Input.GetKey(input))
        {
            jointSpring.targetPosition = targetPresed;
        }
        else
        {
            jointSpring.targetPosition = targetRelease;
        }

        hinge.spring = jointSpring;

    }
}
