using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionRueda : MonoBehaviour
{
    [SerializeField]private float VelocidadRotacion = 100f;
    /*
        NOTA: CUANDO SE MUEVEN OBJETOS QUE TIENEN COLLIDER HAY QUE AGREGAR UN Rigidbody
    */

    /// <summary>
    /// Funcion Utilizada para la rotacion de la rueda, se usa la funcion Time.deltaTime para normalizar
    /// el tiempo sin tomar en cuenta los fps que tenga el equipo 
    /// </summary>
    void Update()
    {
        // AL MOVER O ROTAR UN ELEMENTO ES IDEAL MULTIPLICAR POR Time.deltaTime (Controla los frames)
        transform.Rotate(new Vector3(0,0, VelocidadRotacion * Time.deltaTime));
    }
    
}
