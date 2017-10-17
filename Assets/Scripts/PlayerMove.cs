using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float m_forwardSpeed = 20f;
    public float m_backSpeed = 15f;
 
void Update()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            transform.localPosition += new Vector3(0f, 0f, Input.GetAxis("Vertical") * m_forwardSpeed * Time.deltaTime);
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            transform.localPosition += new Vector3(0f, 0f, Input.GetAxis("Vertical") * m_backSpeed * Time.deltaTime);
        }     
    }

}
