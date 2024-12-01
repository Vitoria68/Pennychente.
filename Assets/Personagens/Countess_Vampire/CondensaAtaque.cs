using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CondensaAtaque : MonoBehaviour
{
    public GameObject projetilPrefab; // Prefab do projetil
    public GameObject projetilPrefabD;
    public Transform pontoDeDisparo; // Ponto de origem do disparo
    public float forcaDisparo = 10f;
    public Animator anim;
    public Codensa codensa;

    [SerializeField] private Transform attackpoint;
    [SerializeField] private LayerMask layer;
    public float radius;
    [SerializeField] private SpriteRenderer sprite;
    //[SerializeField] private Animator anim;
    public Player player;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void attack()
    {
        Collider2D hit = Physics2D.OverlapCircle(attackpoint.position, radius, layer);
        if (hit != null)
        {
            //bateu player
            Debug.Log("baateu");
            //player.OnHit();
            player.health -= 3;
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(attackpoint.position, radius);
    }

    private void Disparar()
    {
        Quaternion rotacao = Quaternion.Euler(0, 0, 0);
        if (codensa.esquerda)
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
