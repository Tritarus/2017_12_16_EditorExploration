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
    private float _life;
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
            value = Mathf.Clamp01(value);
            _life = value;
            _onLifeChange.Invoke(_life);
        }
    }
    public void Start()
    {

        _onLifeChange.AddListener(VieChanger);
    }

    private void RetirerDesVies(float lifeAdditionnel)
    {
        Value += lifeAdditionnel;
    }

    private void AfficherAttackInConsole(float what)
    {
        Debug.Log("Life:" + Value);
    }

    private void VieChanger(float nouvelleVie)
    {
        Debug.Log("Nouvelle vie:" + nouvelleVie);
    }

    public void OnValidate()
    {
        if (_useDebugLog)
            Debug.Log("Hey Mon ami");
        Value = _life;
    }
    public void Reset()
    {

    }

    #region CLASS INTERN
    [Serializable]
    public class LifeChangeEvent : UnityEvent<float> { }
    #endregion

}
