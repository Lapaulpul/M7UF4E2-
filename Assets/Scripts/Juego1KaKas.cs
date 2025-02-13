using UnityEngine;

public class DestruirModelo : MonoBehaviour
{
    public SpriteRenderer spriteParaSeguir; // Asigna el SpriteRenderer del sprite que quieres que siga al ratón

    private void Start()
    {
        if (spriteParaSeguir == null)
        {
            Debug.LogError("Debes asignar el SpriteRenderer en el Inspector.");
            return;
        }
    }

    private void Update()
    {
        // Obtiene la posición del ratón en coordenadas del mundo
        Vector3 posicionDelMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        posicionDelMouse.z = 0f; // Asegura que la coordenada z sea 0 para que el sprite se mueva en el plano 2D

        // Actualiza la posición del sprite para que siga al ratón
        spriteParaSeguir.transform.position = posicionDelMouse;
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}