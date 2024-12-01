using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyLife : MonoBehaviour
{
    public float health;
    public float totalHealth;
    public Image healthBar;
    public SpriteRenderer sprite;
    public TrocaCena TR;
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

        health--;
            StartCoroutine(FlashRed());
        if (health <= 0)
        {
            TR.inimigo--;
        }
          //  vampire.health--;
          //  vampire.healthBar.fillAmount = vampire.health / vampire.totalHealth;
        
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
        // isHitting = false;
    }

}
