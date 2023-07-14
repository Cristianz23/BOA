using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pregunta : MonoBehaviour
{

    public Color wantedColor;
    public Button button; 
    /// <summary>
    /// Funcion utilizada para cambiar de color cuando la respuesta es correcta
    /// </summary>
    public void CambiarColorBoton(){
        ColorBlock cb = button.colors;
        cb.normalColor = wantedColor;
        cb.highlightedColor = wantedColor;
        cb.pressedColor = wantedColor;
        button.colors = cb;
        int activeSceneIndex = SceneManager.GetActiveScene().buildIndex - 1;
        SceneManager.LoadScene(activeSceneIndex);
    }
}
