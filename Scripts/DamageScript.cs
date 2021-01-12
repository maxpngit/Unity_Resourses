using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    public int DamageCount;
    
    public ParticleSystem Particles;

    /*
    private void Start()
    {
        Debug.Log("Стартуем!!");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Collision Exit");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Collision Stay");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Enter");
    }
    */
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Player player = other.gameObject.GetComponent<Player>();
            player.Damage(DamageCount);
            //Debug.Log("Урон: " + DamageCount);
            Particles.Play(); //Запускаем эффект, для чего внутрь маятника помещаем ParticleSystem, выключаем Play on awake и Looping
        }
    }
}