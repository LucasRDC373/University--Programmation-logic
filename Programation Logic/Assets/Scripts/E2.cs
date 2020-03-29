using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Ejercicio 1

        float damageBase = 100f;
        float damageCritical = damageBase * damageBase + damageBase / 100 * 8;
        print("El daño critico es de: " + damageCritical);

        // Ejercicio 2

        float maximunLife = 150f;
        float actualLife = 50f;
        float criticalLife = maximunLife / 100 * 30;

        if (actualLife >= criticalLife)
        {
            print("Tienes vida suficiente para seguir");
        }
        else
        {
            print("Es urgente que te cures o moriras!");
        }

        // Ejercicio 3

        
        int turn = 1;

        if (turn == 1)
        {
            print("El turno es del Jugador 1");
            turn = 2;
        }
        else if(turn != 1)
        {
            print("El turno es del jugador 2");
            turn = 1;
        }

        bool turn1 = false;

        if(turn1 == true)
        {
            print("El turno es del Jugador 1");
            turn1 = false;
        }
        else
        {
            print("El turno es del Jugador 2");
            turn1 = true;
        }
       



    }
}
