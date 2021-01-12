using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarOut : MonoBehaviour
{
    // Ссылка на скрипт игрока
    public CarIn Player;
    
    void Update()
    {
        // При нажатии пробела
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Вызываем функцию CarOut у игрока
            Player.CarOut();
        }
    }
}