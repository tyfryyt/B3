using UnityEngine;
using UnityEngine.InputSystem; // ��������� ������������ ��� ��� Input System

public class GravityController : MonoBehaviour
{
    // ��������� ����������
    private Vector3 initialGravity = new Vector3(0, -9.81f, 0);

    // ����� ����������
    private Vector3 newGravity = new Vector3(0, 9.81f, 0);

    void Update()
    {
        // ��������� ������� ������� (��������, Space)
        if (Keyboard.current.spaceKey.wasPressedThisFrame) // ���������� Input System
        {
            // ������ ����������
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