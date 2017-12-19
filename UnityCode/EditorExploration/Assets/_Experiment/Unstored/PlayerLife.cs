using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour{

    public Life _life;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Health")
            _life.HealOf(0.5f);
        else
            _life.DommageOf(0.2f);

    }
}
