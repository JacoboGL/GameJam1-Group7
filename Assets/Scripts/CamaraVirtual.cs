using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraVirtual : MonoBehaviour
{
    public Transform target; // El transform del personaje que sigue la cámara
    public float rotationSpeed = 5f; // Velocidad de rotación de la cámara

    private void Update()
    {
        // Verifica si hay un objetivo asignado
        if (target != null)
        {
            // Calcula la posición relativa del personaje y la cámara
            Vector3 relativePos = target.position - transform.position;

            // Calcula la rotación deseada basándose en la posición relativa
            Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);

            // Aplica la rotación suavemente
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
        }
    }
}
