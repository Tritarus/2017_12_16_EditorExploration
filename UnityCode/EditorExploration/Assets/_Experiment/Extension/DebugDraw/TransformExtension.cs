using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class Extension  {

    public static void DrawCartesian(this Transform debug, float size = 1, float time=0)
    {

        Debug.DrawLine(debug.position, debug.position + debug.forward * size,Color.blue,time);
        Debug.DrawLine(debug.position, debug.position + debug.up * size, Color.green, time);
        Debug.DrawLine(debug.position, debug.position + debug.right * size, Color.red, time);

    }
}
