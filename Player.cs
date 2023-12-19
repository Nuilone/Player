using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int health = 10;

    public int damage = 2;

    public int coins;

    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Здоровье игрока: " + health);
    }
}
