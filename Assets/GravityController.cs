using UnityEngine;
using UnityEngine.InputSystem; // Добавляем пространство имён для Input System

public class GravityController : MonoBehaviour
{
    // Начальная гравитация
    private Vector3 initialGravity = new Vector3(0, -9.81f, 0);

    // Новая гравитация
    private Vector3 newGravity = new Vector3(0, 9.81f, 0);

    void Update()
    {
        // Проверяем нажатие клавиши (например, Space)
        if (Keyboard.current.spaceKey.wasPressedThisFrame) // Используем Input System
        {
            // Меняем гравитацию
            if (Physics.gravity == initialGravity)
            {
                Physics.gravity = newGravity;
            }
            else
            {
                Physics.gravity = initialGravity;
            }
        }
    }
}