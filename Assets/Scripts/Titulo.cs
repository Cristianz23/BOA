using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Titulo : MonoBehaviour
{
    [SerializeField] float TiempoEnPantalla = 3f;

    void Start()
    {
        
    }

    /// <summary>
    /// La funcion update aqui es utilizada para desaparecer el Titulo despues de unos segundos
    /// </summary>
    void Update()
    {
        TiempoEnPantalla -= Time.deltaTime;
        if (TiempoEnPantalla <= 0) {
            Destroy(this.gameObject, 0.5f);
        }
    }


}
