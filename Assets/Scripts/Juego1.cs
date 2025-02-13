using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class CambiarCamara : MonoBehaviour
{
   

    private bool usandoCamaraPrincipal = true;
    public void ActivateCamera(CinemachineVirtualCamera camActivate)
    {
        Debug.Log(camActivate.gameObject.name);
        camActivate.enabled = true;
    }
    public void DesactiveCamera(CinemachineVirtualCamera camDesactivate)
    {
        camDesactivate.enabled = false;
    }
}