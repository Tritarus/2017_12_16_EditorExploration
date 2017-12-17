using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DisplayPath : MonoBehaviour {

    [Header("Params")]
    public Color _pathColor = Color.green;
    public float _time =500;


    [Header("Debug")]
    public Vector3 _newPoint;
    public Vector3 _previousPoint;

    private Transform _t;
    // Use this for initialization
    void Awake () {
        _t = transform;
	}
	
	// Update is called once per frame
	void Update () {
       

        _previousPoint = _newPoint;
        _newPoint = _t.position;
        if (_previousPoint == Vector3.zero)
            return;
        if (_previousPoint == _newPoint)
            return;

        Debug.DrawLine(_previousPoint, _newPoint, _pathColor, _time);

    }

}
