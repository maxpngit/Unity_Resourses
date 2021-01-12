using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 StartPoint;

    public int StartHp; //Здоровье при старте

    private int currentHp; //Текущее здоровье
    
    private void Start()
    {
        StartPoint = transform.position;
        currentHp = StartHp; // Восстанавливаем здоровье
    }

    public void Restart()
    {
        transform.position = StartPoint;
        currentHp = StartHp; // Восстанавливаем здоровье
    }

    public void Damage(int d)
    {
        currentHp -= d; // currentHp = currentHp - d;
        
        if (currentHp <= 0)
        {
            Restart();
        }

        Debug.Log("Текущее здоровье: " + currentHp);
    }
}

