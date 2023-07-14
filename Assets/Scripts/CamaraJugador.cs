using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraJugador : MonoBehaviour
{
    [SerializeField]private Transform playerTransform;

   /// <summary>
   /// Aplicacion utilizada para actualizar el movimiento de la camara respecto al jugador
   /// </summary>
    void Update()
    {
        if(playerTransform.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, playerTransform.position.y, transform.position.z);
        }
    }
}
