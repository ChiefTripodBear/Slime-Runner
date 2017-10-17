using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    public float m_turnSpeed = 200f;

    void Update ()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.Rotate(0f, Input.GetAxis("Horizontal") * m_turnSpeed * Time.deltaTime, 0f);
        }

    }
}
