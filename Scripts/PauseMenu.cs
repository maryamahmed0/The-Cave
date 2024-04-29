
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject Pause_menu;
    public void Pause()
    {
        Pause_menu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        Pause_menu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Restart()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
