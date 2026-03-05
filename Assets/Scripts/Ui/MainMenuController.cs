using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void GoToLobby() => SceneManager.LoadScene("Lobby");
    public void GoToHowToPlay() => SceneManager.LoadScene("HowToPlay");
    public void GoToSettings() => SceneManager.LoadScene("Settings");
}
