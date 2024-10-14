using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] private KeyCode right = KeyCode.D; //Кнопка клавиатуры для движения вправо
    [SerializeField] private KeyCode left = KeyCode.A; //Кнопка клавиатуры для движения влево
    [SerializeField] private KeyCode forward = KeyCode.W; //Кнопка клавиатуры для движения вперед
    [SerializeField] private KeyCode backward = KeyCode.S; //Кнопка клавиатуры для движения назад

    [SerializeField] private float rotateSpeed = 10f; //Скорость поворота платформы
    
    //Вызывается в самом начале при запуске проекта/сцены/обьекта
    void Start()
    {
        
    }

    //Вызывается в начале каждого кадра
    void Update()
    {
        if (Input.GetKey(right)) //Проверяем, что игрок нажимает кнопку "вправо"
        {   //Функция Rotate с одним аргументом в виде вектора позволяет поворачивать выбранный обьект (transform - трансформирование обьекта,
            //на котором используеться этот скрипт)
            transform.Rotate(new Vector3(rotateSpeed * Time.deltaTime, 0, 0));
            //rotate speed - наша скорость поворота, Time.deltaTime - время между кадрами, используем для плавности перемещение
            //т.к. перемещение мы делаем в функции Update 
            //Вектор, который подается на вход Rotate - это то, как будт изменяться поворот обьекта (можно в проекте посмотреть
            //справа в панели "Inspector" во вкладке Transform)
        }
        if (Input.GetKey(left))
        {
            transform.Rotate(new Vector3(-rotateSpeed * Time.deltaTime, 0, 0));
        }
    }
}
