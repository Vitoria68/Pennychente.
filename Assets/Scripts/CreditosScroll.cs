using UnityEngine;

public class CreditosScroll : MonoBehaviour
{
    public float velocidadeRolagem = 20f;

    void Update()
    {
        transform.Translate(Vector2.up * velocidadeRolagem * Time.deltaTime);
    }
}