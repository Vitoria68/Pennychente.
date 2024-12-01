using UnityEngine;
using UnityEngine.SceneManagement;

public class TelaDeIntroducaoManager : MonoBehaviour
{
    public string nomeDaProximaCena = "Primeira"; // Nome da cena para onde queremos ir
    public float tempoParaTrocarCena = 60f; // Tempo em segundos para trocar automaticamente

    void Start()
    {
        // Inicia a contagem para mudar de cena automaticamente
        Invoke("TrocarCena", tempoParaTrocarCena);
    }

    void Update()
    {
        // Detecta se a tecla Enter foi pressionada para mudar de cena
        if (Input.GetKeyDown(KeyCode.Return))
        {
            TrocarCena();
        }
    }

    void TrocarCena()
    {
        // Carrega a próxima cena
        SceneManager.LoadScene(nomeDaProximaCena);
    }
}
