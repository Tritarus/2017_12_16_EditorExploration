using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class : MonoBehaviour{

    public Student[] _myStudents;

    private void OnValidate()
    {
        
    }

    public void ResetStudent()
    {
        _myStudents = null;
    }
}

[System.Serializable]
public class Student
{

    public string _name;
    [Range(0, 99)]
    public int _age = 13;

    public enum Beatable { Yes, Sometime, EveryTime,Fry }
    public Beatable _isBeatable;

}