using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mensajes : MonoBehaviour
{
    public void Mensaje1()
    {
        print("Este es el mensaje 1");
    }
    public void Mensaje2()
    {
        print("Este es el mensaje 2");
    }

    public void Mensaje3(string nombre)
    {
        print("Hola "+ nombre + "¿Cómo estás?");
    }
}
