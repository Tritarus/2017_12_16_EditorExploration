using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Memo : MonoBehaviour {
    
    [Tooltip("Subject of the memo")]
    [SerializeField]
    [TextArea(1, 1)]
    private string _titre= "Subject";
    [Tooltip("Explaination of the memo")]
    [SerializeField]
    [TextArea(3,10)]
    private  string _content = "Description";
    public string _creationDate = DateTime.Now.ToString();
    public string _updateDate = DateTime.Now.ToString();

    public void OnValidate()
    {
        _updateDate = DateTime.Now.ToString();
    }

    
}
