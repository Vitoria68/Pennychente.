using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject projetilPrefab; // Prefab do projetil
    public Transform pontoDeDisparo; // Ponto de origem do disparo
    public float forcaDisparo = 0f;
    // Start is called before the first frame update

    private void Update()
    {
        if (Input.GetMouseButtonDown(1) || Input.GetKeyDown(KeyCode.LeftControl))
        {
            Disparar();
        }
    }

    private void Disparar()
    {
        Quaternion rotacao = Quaternion.Euler(0, 0, 0);
        GameObject projetil = Instantiate(projetilPrefab, pontoDeDisparo.position, rotacao);
        Rigidbody2D rb = projetil.GetComponent<Rigidbody2D>();
        rb.AddForce(pontoDeDisparo.right * forcaDisparo, ForceMode2D.Impulse);

    }



}
