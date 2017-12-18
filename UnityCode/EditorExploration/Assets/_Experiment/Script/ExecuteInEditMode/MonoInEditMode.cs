using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// PS: UnityEvent don't work at runtime
/// </summary>
[ExecuteInEditMode]
public class MonoInEditMode : MonoBehaviour {

    [Header("Params")]
    [Tooltip("Does the code is executed in play mode ?")]
    public bool _useInPlayMode;

    [Header("Debug")]
    [SerializeField]
    [Tooltip("Do you want to use debug log message ?")]
    private bool _useDebugLog;
    [Tooltip("Not display the debug log update to void spamming")]
    [SerializeField]
    private bool _useUpdate;


    


    public virtual void Awake()
    {
        
        if (IsNotAllowInPlayMode())
            return;

        Log("[MonoInEditMode]:Awake");
    

    }




    public virtual void Start ()
    {
        if (IsNotAllowInPlayMode())
            return;
        

        Log("[MonoInEditMode]:Start");

    }

    public virtual void OnBecameVisible()
    {

        if (IsNotAllowInPlayMode())
            return;
        
        Log("[MonoInEditMode]:OnBecameVisible");
    }
    public virtual void OnBecameInvisible()
    {
        if (IsNotAllowInPlayMode())
            return;

        

        Log("[MonoInEditMode]:OnBecameInvisible");
    }


    public virtual void OnCollisionEnter(Collision collision)
    {
        Log("[MonoInEditMode]:OnCollisionEnter");

    }

    public virtual void OnCollisionExit(Collision collision)
    {
        Log("[MonoInEditMode]:OnCollisionExit");

    }


    public virtual void OnEnable()
    {
        if (IsNotAllowInPlayMode())
            return;

        
        Log("[MonoInEditMode]:OnEnable");

    }
    public virtual void OnDisable()
    {

        if (IsNotAllowInPlayMode())
            return;
        
        Log("[MonoInEditMode]:OnDisable");
    }

    public virtual void OnDestroy()
    {

        if (IsNotAllowInPlayMode())
            return;

        
        Log("[MonoInEditMode]:OnDestroy");
    }

    #region BADLY AFFECTED
    // /!\ Not working like Play Mode Update (More like OnInspector)
    public virtual  void Update()
    {
        if (IsNotAllowInPlayMode() || !_useUpdate)
            return;

        Log("[MonoInEditMode]:Update");
    }
    // /!\ Not working like Play Mode Update (More like OnInspector)
    public virtual void LateUpdate()
    {
        if (IsNotAllowInPlayMode() || !_useUpdate)
            return;

        Log("[MonoInEditMode]:LateUpdate");
    }

    #endregion

    #region NOT AFFECTED
    /// /!\ NOT AFFECTED
    public void OnMouseDown()
    {
        if (IsNotAllowInPlayMode())
            return;
        Log("[MonoInEditMode]:OnMouseEnter");}
    #endregion

    public void Log(string message) {

        if (_useDebugLog)
            Debug.Log(message);
    }
    private bool IsNotAllowInPlayMode()
    {
        return !_useInPlayMode && Application.isPlaying;
    }
}
