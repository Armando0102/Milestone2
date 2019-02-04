using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    public float fSpeed = 0;
    float fSpeedMax = 5;
    float fAcc = 0.5f;
    float fDec = 0.2f;
    public float rSpeed = 0;
    float rSpeedMax = 500;
    float rAcc = 25;
    float rDec = 10;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (fSpeed < fSpeedMax)
            {
                fSpeed += fAcc;
            }
        }
        else if (fSpeed > 0)
        {
            fSpeed -= fDec;
        }
        else
        {
            fSpeed = 0;
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (rSpeed > -rSpeedMax)
            {
                rSpeed -= rAcc;
            }
        }
        else if (rSpeed < 0)
        {
            rSpeed += rDec;
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (rSpeed < rSpeedMax)
            {
                rSpeed += rAcc;
            }
        }
        else if (rSpeed > 0)
        {
            rSpeed -= rDec;
        }

        transform.position += transform.up * Time.deltaTime * fSpeed;
        transform.Rotate(Vector3.forward * Time.deltaTime * rSpeed);
    }
}
