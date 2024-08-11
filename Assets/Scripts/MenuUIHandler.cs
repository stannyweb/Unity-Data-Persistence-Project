using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField inputField;
    public TextMeshProUGUI bestPlayerName;
    public static string playerName;

    void Start()
    {
        string showBestPlayer = PlayerPrefs.GetString("playerName", "");
        int showBestScore = PlayerPrefs.GetInt("HighScore", 0);

        bestPlayerName.text = $"Best Score: {showBestPlayer} - {showBestScore}";
    }

    public void StartNew()
    {
        playerName = inputField.text;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR 
        EditorApplication.ExitPlaymode();
#else
    Application.Quit();

#endif
    }
}
