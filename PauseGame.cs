using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public GameObject PauseMenuPanel;
    private bool isPaused;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            PauseUnpause();
        }
    }

    public void LoadMainMenu(){
        SceneManager.LoadScene("LandingPage");
    }

    public void PauseUnpause() {
        if (isPaused) {
            isPaused = false;
            PauseMenuPanel.SetActive(false);
            Time.timeScale = 1f;
        } else {
            isPaused = true;
            PauseMenuPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void QuitGame(){
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
