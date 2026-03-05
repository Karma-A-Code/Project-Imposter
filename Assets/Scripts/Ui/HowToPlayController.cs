using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToPlayController : MonoBehaviour
{
   public void GoToMainMenu() => SceneManager.LoadScene("MainMenu");
}
