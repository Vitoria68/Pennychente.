using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
public class Ghost : EnemyLife
{
    [SerializeField] private NavMeshAgent agent;
    //[SerializeField] private AnimatioControl anim;
    private Player player;
    public bool isDead = false;
    [SerializeField] private int distance;
    [SerializeField] private float speed;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        health = totalHealth;
        player = FindAnyObjectByType<Player>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        //   Debug.Log(transform.position.x - player.transform.position.x);
        //    Debug.Log(transform.position.y - player.transform.position.y);
        if (isDead == false)
        {
            agent.SetDestination(player.transform.position);

            if (Vector2.Distance(transform.position, player.transform.position) <= agent.stoppingDistance)
            {
                //parar perto do player
                // anim.playerAnim(2);
            }
            else if (transform.position.x - player.transform.position.x > distance || transform.position.y - player.transform.position.y > distance || transform.position.x - player.transform.position.x < -distance || transform.position.y - player.transform.position.y < -distance)
            {
                agent.speed = 0f;
                // anim.playerAnim(0);
            }
            else
            {
                //anim.SetTrigger("ataque");
                agent.speed = speed;
            }

            float pox = player.transform.position.x - transform.position.x;
            if (pox > 0)
            {
                transform.eulerAngles = new Vector2(0, 0);
            }
            else
            {
                transform.eulerAngles = new Vector2(0, 180);
            }
        }
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            health--;
            OnHit();
        }
    }
}
