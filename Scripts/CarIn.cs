using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Cameras;
using UnityStandardAssets.Vehicles.Car;

public class CarIn : MonoBehaviour
{
    public CarUserControl UserCar; //Машина в которую садится игрок
    public AutoCam Cam; // Камера
    public Transform Anchor; // Объект, который будет показывать, в какой точке игрок покинет машину

    void Start()
    {
        // Выключаем логику машин
        UserCar.enabled = false;
        // Скрипт висит на игроке - говорим камере следить за ним
        Cam.SetTarget(transform);
    }

    // Встроенная функция, срабатывает, когда входим в триггер-коллайдер
    void OnTriggerEnter(Collider other)
    {
        // Проверяем, что столкнулись с нашей машиной
        if (other.gameObject == UserCar.gameObject)
        {
            // Включаем машины
            UserCar.enabled = true;
            // Перенаправляем камеру на машину
            Cam.SetTarget(UserCar.transform);
            // Выключаем игрока от третьего лица
            gameObject.SetActive(false);
        }
    }

    public void CarOut()
    {
        // Перемещаем игрока к объекту-якорю
        transform.position = Anchor.position;
        // Включаем игрока
        gameObject.SetActive(true);
        // Выключаем машину игрока
        UserCar.enabled = false;
        // Настраиваем камеру на игрока
        Cam.SetTarget(transform);
    }
}
