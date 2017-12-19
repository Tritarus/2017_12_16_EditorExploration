using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayPlayerLife : MonoBehaviour{

    public Life _life;
    public Transform _root;
    public Image _fillImage;
    public float _lifeDisplayAsPourcent = 1f;

    public void Awake()
    {
        _life._onLifeChange.AddListener(ListenToLifeChange);
    }

    private void ListenToLifeChange(float newLife)
    {
        _lifeDisplayAsPourcent = newLife;
    }

    public void Update()
    {
        if (_fillImage.fillAmount == _lifeDisplayAsPourcent)
            return;
        _fillImage.fillAmount = Mathf.Lerp(_fillImage.fillAmount, _lifeDisplayAsPourcent, Time.deltaTime);
    }

}
