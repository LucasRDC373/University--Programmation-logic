using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Realice un programa que dados los numeros los divida y muestre el resultado

        float dividendo = 10;
        float divisor = 2;
        float resultado = 0;

        

        if (divisor != 0)
        {
            resultado = dividendo / divisor;
            print("El resultado de la division es: " + resultado);
        }else
        {
            print("No se puede dividir por cero");
        }

        int turno = 15;

        if (turno % 2 == 0)
        {
            print("Es el turno del Jugador 1");
            turno += 1;
        }
        else
        {
            print("Es el turno del jugador 2");
            turno += 1;
        }

        int calificacion = 5;

        if(calificacion >= 4 && calificacion <= 6)
        {
            print("El alumno esta aprobado");
        }
        else if(calificacion <= 3)
        {
            print("El alumno esta desaprobado");
        }
        else if(calificacion >= 7)
        {
            print("El alumno esta promocionado");
        }

        int rpmDelJugador = 1200;

        if (rpmDelJugador < 1000)
        {
            print("Debes bajar el cambio de tu vehiculo");
        }
        else if(rpmDelJugador >= 1000 && rpmDelJugador <= 3000)
        {
            print("Manten el cambio de tu vehiculo");
        }
        else if(rpmDelJugador > 3000)
        {
            print("Debes subir el cambio de tu vehiculo");
        }

    }
}
