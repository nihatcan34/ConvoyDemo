using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public void GetInput()
    {
        m_horizontalInput = Input.GetAxis("Horizontal");
        m_verticalInput = Input.GetAxis("Vertical");
    }

    private void Steer()
    {
        m_steeringAngle = maxSteerAngle * m_horizontalInput;
        leftWheel.steerAngle = m_steeringAngle;
        rightWheel.steerAngle = m_steeringAngle;
    }

    private void Accelerate()
    {
        leftWheel.motorTorque = m_verticalInput * motorForce;
        rightWheel.motorTorque = m_verticalInput * motorForce;
    }

    private void UpdateWheelPoses()
    {
        UpdateWheelPose(leftWheel,leftWheelT);
        UpdateWheelPose(rightWheel, rightWheelT);
        UpdateWheelPose(backLeftWheel, backLeftWheelT);
        UpdateWheelPose(backRightWheel, backRightWheelT);
    }

    private void UpdateWheelPose(WheelCollider _collider,Transform _transform)
    {
        Vector3 _pos = _transform.position;
        Quaternion _quat = _transform.rotation;

        _collider.GetWorldPose(out _pos, out _quat);

        _transform.position = _pos;
        _transform.rotation = _quat;
    }

    private void FixedUpdate()
    {
        GetInput();
        Steer();
        Accelerate();
        UpdateWheelPoses();
    }

    private float m_horizontalInput;
    private float m_verticalInput;
    private float m_steeringAngle;

    public WheelCollider leftWheel, rightWheel;
    public WheelCollider backLeftWheel, backRightWheel;
    public Transform leftWheelT, rightWheelT;
    public Transform backLeftWheelT, backRightWheelT;
    public float maxSteerAngle = 30;
    public float motorForce = 50;

}
