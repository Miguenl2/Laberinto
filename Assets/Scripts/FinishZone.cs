using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishZone : MonoBehaviour
{
    public GameObject winText; // Referencia al texto de victoria

    void Start()
    {
        Debug.Log("🔍 Start() ejecutándose...");

        if (winText != null)
        {
            winText.SetActive(false); // Ocultar el texto al inicio
            Debug.Log($"✅ winText ocultado correctamente. Estado: {winText.activeSelf}");
        }
        else
        {
            Debug.LogError("⚠ winText no está asignado en el Inspector.");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log($"🚀 OnTriggerEnter detectado con: {other.name}");

        if (other.CompareTag("Player")) // Asegurar que solo el jugador activa el mensaje
        {
            Debug.Log("🎉 Jugador llegó a la meta!");

            if (winText != null)
            {
                winText.SetActive(true); // Mostrar el texto de victoria
                Debug.Log($"🏆 winText activado. Estado: {winText.activeSelf}");
            }
            else
            {
                Debug.LogError("⚠ winText no está asignado en el Inspector.");
            }
        }
    }
}