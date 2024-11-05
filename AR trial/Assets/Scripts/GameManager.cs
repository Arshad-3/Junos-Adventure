using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private float time;
    private float lowestTime = 10000;
    private int waypointsCollected;
    private string username;

    public readonly string leaderboardId = "ExcelAR";

    public string Username
    {
        get { return username; }
        set { username = value; }
    }

    public int WaypointsCollected
    {
        get { return waypointsCollected; }
        set { waypointsCollected = value; }
    }
    public float Time { 
        get { return time; }
        set { time = value; }
    }

    public float LowestTime
    {
        get { return lowestTime; }
        set { lowestTime = value; }
    }


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(instance);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
