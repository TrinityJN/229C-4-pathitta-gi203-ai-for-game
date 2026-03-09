using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 3.0f;      // ความเร็วในการเคลื่อนที่
    public float rotationSpeed = 50.0f; // ความเร็วในการหมุน

    void Update()
    {
        // 1. เคลื่อนที่ไปด้านหน้าตามทิศทางของวัตถุ (แกน Z) อย่างต่อเนื่อง
        // อ้างอิงแนวคิด transform.forward จากบทเรียน Raycast และ Constant Force
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        // 2. หมุนวัตถุไปรอบแกน Y เล็กน้อยเพื่อให้ดูมีการเคลื่อนไหว ไม่เป็นเส้นตรงจนเกินไป
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}