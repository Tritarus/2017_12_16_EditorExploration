using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickRotate  : MonoBehaviour
{

    public Vector3 m_rotate = new Vector3(0,1,0);
    public float m_speed = 90f;
    public float m_speedConfigSpeed = 1f;
    #region publicMembers
    #endregion

    #region system
    void Start ()
    {
        
    }

    void Update ()
    {
        transform.Rotate(m_rotate * Time.deltaTime * m_speed);
        if (Input.GetKey(KeyCode.UpArrow))
            m_speed += Time.deltaTime * m_speedConfigSpeed;
        if (Input.GetKey(KeyCode.DownArrow))
            m_speed -= Time.deltaTime * m_speedConfigSpeed;
    }
    #endregion

    #region mainMethods
    #endregion

    #region utils
    #endregion
    #region private&protectedMembers
    #endregion
}
