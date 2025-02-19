using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class J1KaKas : MonoBehaviour
{
    public Image imageToFollowMouse; // Imagen que seguirá el ratón

    void Update()
    {
        
        // Actualizar la posición de la imagen para que siga el ratón
        Vector3 mousePosition = Input.mousePosition;
        imageToFollowMouse.transform.position = mousePosition;
    }
}