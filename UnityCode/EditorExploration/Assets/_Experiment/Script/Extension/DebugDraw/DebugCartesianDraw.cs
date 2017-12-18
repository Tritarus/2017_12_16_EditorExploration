using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DebugCartesianDraw : MonoBehaviour {

    public Transform _target;
    public float _size=1;

    void Update () {
        _target.DrawCartesian(_size);
        
    }

    private void Reset()
    {
        if (_target == null)
            _target = this.transform;
    }
}
