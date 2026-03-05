using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsController : MonoBehaviour
{
    // public void GoToMainMenu() => SceneManager.LoadScene("MainMenu");
    [Header("Config")]
    [SerializeField] private GameConfig gameConfig;

    [Header("UI")]
    [SerializeField] private TMP_InputField playerCountInput;
    [SerializeField] private TMP_InputField imposterCountInput;
    [SerializeField] private bool RandomImposter;

    private void Start()
    {
      LoadFromConfig();
    }

    private void LoadFromConfig()
    {
        if (gameConfig == null) { Debug.LogError("SettingsController: Config not assigned."); return; }

    }

}
