using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float m_forwardSpeed = 20f;
    public float m_backSpeed = 15f;
    public float m_turnSpeed = 200f;

    void Update()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            transform.position += transform.forward * Input.GetAxis("Vertical") * m_forwardSpeed * Time.deltaTime;
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            transform.position += transform.forward * Input.GetAxis("Vertical") * m_backSpeed * Time.deltaTime;
        }

        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.Rotate(0f, Input.GetAxis("Horizontal") * m_turnSpeed * Time.deltaTime, 0f);
        }
    }

}
