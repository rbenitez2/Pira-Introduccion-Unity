using UnityEngine;
using UnityEngine.UI;

public class LogButtons : MonoBehaviour
{
    // TAREA 1: Haz que este botón muestre un mensaje normal en consola (color blanco)
    public void ShowLogInfoMessage()
    {
        Debug.Log("Este es un mensaje normal y deberia salir en BLANCO");
    }

    // TAREA 2: Haz que este botón muestre una ADVERTENCIA (triángulo amarillo)
    public void ShowLogWarningMessage()
    {
        Debug.LogWarning("Este es un mensaje normal y deberia salir en AMARILLO");
    }

    // TAREA 3: Haz que este botón muestre un ERROR (octágono rojo)
    // PLUS: Investiga cómo hacer que Unity se PAUSE automáticamente al pulsar este botón.
    public void ShowLogErrorMessage()
    {
        Debug.LogError("Este es un mensaje normal y deberia salir en ROJO");
        Debug.Break();
    }
}
