using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int health = 10;

    public GameObject fireballPrefab;
    public Transform attackPoint;

    public int damage = 2;

    public int coins;

    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Здоровье игрока: " + health);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
}
