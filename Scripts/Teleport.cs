using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    // Подключаем сюда конечную точку телепорта
    public Transform Target;

       // При входе объекта в триггер (этот объект - игрок, то есть other)
    void OnTriggerEnter(Collider other)
    {
        // Телепортировать объект на конечную точку
        other.transform.position = Target.transform.position;
       // Перемещаем партиклы к игроку
    }
}