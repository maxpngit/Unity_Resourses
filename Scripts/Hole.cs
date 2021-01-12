using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{    
    void OnTriggerEnter(Collider a)
    {
        a.isTrigger = true;
    }

    void OnTriggerExit(Collider a)
    {
        a.isTrigger = false;
        a.GetComponent<Player>().Restart();
    }
}
