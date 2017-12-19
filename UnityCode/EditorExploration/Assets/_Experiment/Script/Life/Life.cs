using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//public class LifeInInspector : MonoBehaviour {
//    [SerializeField]
//    public Life _defaultLife;
//    [SerializeField]
//    public Life _life;
//}

[System.Serializable]
public class Life : MonoBehaviour
{

    [Header("Params")]
    [Range(0, 1f)]
    [SerializeField]
    [Tooltip("Life of the target between 0-1 pourcent")]
    /// <summary>
    /// Life of the target between 0-1 pourcent
    /// </summary>
    private float _life=1;
    /// <summary>
    /// Life of the target between 0-1 pourcent
    /// </summary>
    /// 
    [Header("Events")]

    public UnityEvent _onDeath;

    //[SerializeField]
    public LifeChangeEvent _onLifeChange;
    public UnityEvent _onFullLife;

    //        public UnityEvent _

    [Header("Debug")]
    public bool _useDebugLog;


    public float Value
    {
        get { return _life; }
        set 
        {
            float oldValue = _life;
            float newValue = Mathf.Clamp01(value);
            _life = value;

            if (newValue == 1f)
                _onFullLife.Invoke();
            if (newValue == 0f)
                _onDeath.Invoke();

            _onLifeChange.Invoke(newValue);
        }
    }
    

    public void OnValidate()
    {
        //if (_useDebugLog)
        //    Debug.Log("Hey Mon ami");
        Value = _life;
    }

    internal void DommageOf(float dommageInPourcent)
    {
        Value -= dommageInPourcent;
    }

    internal void HealOf(float healInPourcent)
    {
        Value -= healInPourcent;
    }

    #region CLASS INTERN
    [Serializable]
    public class LifeChangeEvent : UnityEvent<float> { }
    #endregion

}
