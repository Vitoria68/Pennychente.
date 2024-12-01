using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalhacoanimatoControle : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite;

    [SerializeField] private bool isHitting = false;

    public Player player;
    [SerializeField] private Transform attackPoint;
    public float radius;
    public LayerMask Layer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnHit()
    {
        if (!isHitting)
        {
            player.health--;
            StartCoroutine(FlashRed());
            isHitting = true;
        }


    }

    IEnumerator FlashRed()
    {
        for (int i = 0; i < 1; i++)
        {
            sprite.color = Color.red;
            yield return new WaitForSeconds(0.5f);
            sprite.color = Color.white;
            yield return new WaitForSeconds(0.5f);
        }
        isHitting = false;
    }
    public void onAttack()
    {
        Collider2D hit = Physics2D.OverlapCircle(attackPoint.position, radius, Layer);

        if (hit != null)
        {
            hit.GetComponentInChildren<EnemyLife>().OnHit();
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(attackPoint.position, radius);
    }
}
