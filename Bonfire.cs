using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonfire : MonoBehaviour
{
    public float lifeTime;
    public float tempUp = 0.2f;
    //Скорость согревания
    void Update()
    {
        lifeTime -= 1 * Time.deltaTime;
        if (lifeTime <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerStay(Collider other)
    //Триггер при стоянии у костра
    {
        if (other.GetComponent<Temperature>() != null)
        {
            other.GetComponent<Temperature>().TemperatureUp(tempUp);
        }
    }
}