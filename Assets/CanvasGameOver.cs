using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasGameOver : MonoBehaviour
{
    public string faseAtu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void menu()
    {
        SceneManager.LoadScene("inicio");
    }
    public void faseAtual()
    {
        SceneManager.LoadScene(faseAtu);
        Debug.Log("pão");
    }
    public void inicio()
    {
        SceneManager.LoadScene("Primeira");
    }
}
