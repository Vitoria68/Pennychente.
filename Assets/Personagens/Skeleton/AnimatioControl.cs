using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatioControl : MonoBehaviour
{
    [SerializeField] private Transform attackpoint;
    [SerializeField] private LayerMask layer;
    public float radius;
    [SerializeField] private SpriteRenderer sprite;
    [SerializeField] private Animator anim;
    public Player player;

    public PalhacoanimatoControle palahaco;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playerAnim(int value)
    {
        anim.SetInteger("transicao", value);
    }


    public void attack()
    {
        Collider2D hit = Physics2D.OverlapCircle(attackpoint.position, radius, layer);
        if (hit != null)
        {
            //bateu player
            Debug.Log("baateu");
            //player.OnHit();
            player.health--;
            palahaco.OnHit();
        }
        else
        {

        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(attackpoint.position, radius);
    }
}
