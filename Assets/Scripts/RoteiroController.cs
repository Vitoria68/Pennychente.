using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoteiroController : MonoBehaviour
{
    public Button btnIniciar;
    public GameObject dialogoPanel;
    // Start is called before the first frame update
    void Start()
    {

        dialogoPanel.SetActive(true);
        btnIniciar.onClick.AddListener(FecharDialogo);
        Time.timeScale = 0;
    }
    private void Update()
    {
        // Verifica se a tecla Enter foi pressionada
        if (Input.GetKeyDown(KeyCode.Return))
        {
            FecharDialogo();
        }
    }

    private void FecharDialogo()
    {
        dialogoPanel.SetActive(false);
        Time.timeScale = 1;
        IniciarCena();
    }

    private void IniciarCena()
    {
        Debug.Log("Cena Iniciada");
    }
}
