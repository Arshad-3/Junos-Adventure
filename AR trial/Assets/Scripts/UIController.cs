using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.Services.Authentication;
using Unity.Services.Leaderboards;
using Newtonsoft.Json;

public class UIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI waypointsCount;
    [SerializeField] private TextMeshProUGUI time;
    [SerializeField] private GameObject menu;


    private void Start()
    {
        Debug.Log(AuthenticationService.Instance.PlayerName);
        Menu();
    }


    private void Update()
    {
        time.text = "Time: " + ((int)GameManager.instance.Time).ToString();
        waypointsCount.text = "Waypints: " + (GameManager.instance.WaypointsCollected/2).ToString() + "/7";

        if (menu.activeInHierarchy)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1f;
        }

        if ((GameManager.instance.WaypointsCollected / 2) >= 7)
        {
            Invoke("Restart", 0.3f);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Leaderboard()
    {
        SceneManager.LoadScene("Leaderboard");
    }

    public void Play()
    {
        menu.SetActive(false);
    }

    public void Menu()
    {
        menu.SetActive(true);
    }


    public void Logout()
    {
        AuthenticationService.Instance.SignOut();
        SceneManager.LoadScene("MainMenu");
    }
}
