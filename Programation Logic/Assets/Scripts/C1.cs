using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Las variables son "cajas" que almacenas distintos tipos de datos y poseen una etiqueta para identificarlas.
        //Las variables pueden ser de distinto tipo como Int, FLoat, String, etc. 
        //Las etiquetas de las variables no pueden contener caracteres que no se usen en el idioma ingles y no pueden 
        //ser iguales a palabras reservadas ya establecidas por el lenguaje.
        //Los datos de las variables pueden cambiarse luego de ser declarados inicialmente.
        //Los operadores aritmeticos son: + (SUMA), - (RESTA), / (DIVISION), * (MULTIPLICACION), % (MODULO)
        int x = 3093218;
        int y = 5093844;
        int z = x + y;

        //print es una función que me permite poner en la consola un mensaje
        //print ("texto");
        print("Hello, World!");
        print("El resultado es: " + z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
