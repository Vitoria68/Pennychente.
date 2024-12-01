using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button btPlay;


    private void Awake()
    {
        btPlay.onClick.AddListener(OnButtonPlayClick);
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return)){
            OnButtonPlayClick();
        }
    }

    private void OnButtonPlayClick()
    {
        Debug.Log("PLAY");
        SceneManager.LoadScene("Introducao");
    }
}
