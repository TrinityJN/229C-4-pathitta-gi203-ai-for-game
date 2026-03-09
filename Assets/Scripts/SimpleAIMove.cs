using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAIMove : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 3f;

    [Header("Rotation")]
    public float rotationSpeed = 50f;
    public float directionChangeInterval = 2f;

    private float timer;
    private float targetTurn;

    void Start()
    {
        ChooseNewDirection();
    }

    void Update()
    {
        // เดินไปข้างหน้า
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        // หมุนเล็กน้อย
        transform.Rotate(Vector3.up * targetTurn * rotationSpeed * Time.deltaTime);

        // นับเวลาเพื่อเปลี่ยนทิศ
        timer += Time.deltaTime;
        if (timer >= directionChangeInterval)
        {
            ChooseNewDirection();
            timer = 0f;
        }
    }

    void ChooseNewDirection()
    {
        // เลือกทิศหมุนแบบสุ่ม (-1 ถึง 1)
        targetTurn = Random.Range(-1f, 1f);
    }
}