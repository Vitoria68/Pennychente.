using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueR : MonoBehaviour
{
    public GameObject projetilPrefab; // Prefab do projetil
    public GameObject projetilPrefabD;
    public Transform pontoDeDisparo; // Ponto de origem do disparo
    public float forcaDisparo = 10f;
    public Animator anim;
    public Rambo rambo;
    // Start is called before the first frame update
    void Start()
    {

    }


    private void Disparar()
    {
        Quaternion rotacao = Quaternion.Euler(0, 0, 0);
        if (rambo.esquerda)
        {
            GameObject projetil = Instantiate(projetilPrefab, pontoDeDisparo.position, rotacao);
            Rigidbody2D rb = projetil.GetComponent<Rigidbody2D>();
            rb.AddForce(pontoDeDisparo.right * forcaDisparo, ForceMode2D.Impulse);
        }
        else
        {

            GameObject projetil = Instantiate(projetilPrefabD, pontoDeDisparo.position, rotacao);
            Rigidbody2D rb = projetil.GetComponent<Rigidbody2D>();
            rb.AddForce(pontoDeDisparo.right * forcaDisparo, ForceMode2D.Impulse);
        }

    }
}
