using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Pro práci s UI

public class StartGame : MonoBehaviour
{
    void Start()
    {
        // Přidá event listener k tlačítku, pokud je script připojen přímo na tlačítko
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(LoadGameScene);
        }
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("game");
    }
}