using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Animator anim;
    private Vector2 direction;
    public Rigidbody2D rig;
    public float speed = 5;
    public float health;
    public float totalHealth;
    public Image healthBar;

    public PalhacoanimatoControle palahaco;
    public GameObject ativar;
    // Start is called before the first frame update
    void Start()
    {
        health = totalHealth;
        healthBar.fillAmount = health / totalHealth;
    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        //  Debug.Log(direction.x);
        if (direction.x > 0)
        {
            anim.SetBool("walk", true);
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (direction.x < 0)
        {
            anim.SetBool("walk", true);
            gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (direction.y != 0)
        {
            anim.SetBool("walk", true);
        }
        else
        {
            anim.SetBool("walk", false);
        }
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {

            anim.SetTrigger("attack");
        }
        if (health <= 0)
        {
            //cena game over
            ativar.SetActive(true);
            Destroy(gameObject);

        }
        healthBar.fillAmount = health / totalHealth;
    }


    private void FixedUpdate()
    {
        rig.MovePosition(rig.position + direction * speed * Time.fixedDeltaTime);
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            palahaco.OnHit();

        }

        healthBar.fillAmount = health / totalHealth;
    }
}
