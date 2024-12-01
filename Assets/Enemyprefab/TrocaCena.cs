using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TrocaCena : MonoBehaviour
{
    public int inimigo;
    public string proxmaCena;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inimigo <= 0)
        {
            SceneManager.LoadScene(proxmaCena);
        }
    }
}
