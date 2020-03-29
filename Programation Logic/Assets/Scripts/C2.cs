using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int numero2 = 15;
        int numero1 = 15;
        int suma = numero1 + numero2;
        print("La suma es: " + suma);

        float damageBase = 175f;
        float damageCritical = damageBase + damageBase + damageBase * 0.8f; 
        print("El daño crtico fue de: " + damageCritical);

        float dividendo = 100f;
        float divisor = 0f;

        if(divisor != 0f)
        {
            float resultado = dividendo / divisor;
            print("El resultado es: " + resultado);
        }else 
        {
            print("No se puede dividir un numero por cero");
        }
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
