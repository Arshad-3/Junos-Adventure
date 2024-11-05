using UnityEngine;
using Unity.Services.Authentication;
using Unity.Services.Core;
using TMPro;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;
using Newtonsoft.Json;
using Unity.Services.Leaderboards;

public class Login : MonoBehaviour
{
    [SerializeField] private TMP_InputField usernameInput = default;
    [SerializeField] private TMP_InputField passwordInput = default;
    [SerializeField] private TextMeshProUGUI username;

    [SerializeField] private GameObject signIn;
    [SerializeField] private GameObject signUp;
    [SerializeField] private GameObject alreadyHave;
    [SerializeField] private GameObject dontHave;

    async void Start()
    {
        await UnityServices.InitializeAsync();
    }

    public async void Create()
    {
        string username = usernameInput.text;
        string password = passwordInput.text;
        await SignUpWithUsernamePassword(username, password);
        GameManager.instance.Username = this.username.text;
        GameManager.instance.LowestTime = 10000;
        LeaderboardShowcase.ResetPlayer();
    }
    async Task SignUpWithUsernamePassword(string username, string password)
    {
        try
        {
            await AuthenticationService.Instance.SignUpWithUsernamePasswordAsync(username, password);
            await AuthenticationService.Instance.UpdatePlayerNameAsync(username);
            Debug.Log("SignUp is successful.");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
        catch (AuthenticationException ex)
        {
            // Compare error code to AuthenticationErrorCodes
            // Notify the player with the proper error message
            Debug.LogException(ex);
        }
        catch (RequestFailedException ex)
        {
            // Compare error code to CommonErrorCodes
            // Notify the player with the proper error message
            Debug.LogException(ex);
        }
    }

    public async void LogIn()
    {
        string username = usernameInput.text;
        string password = passwordInput.text;
        await SignInWithUsernamePassword(username, password);
        GameManager.instance.Username = this.username.text;
        var scoreResponse = await LeaderboardsService.Instance.GetPlayerScoreAsync(GameManager.instance.leaderboardId);
        Debug.Log(JsonConvert.SerializeObject(scoreResponse));
        GameManager.instance.LowestTime = (int)scoreResponse.Score;
    }
    async Task SignInWithUsernamePassword(string username, string password)
    {
        try
        {
            await AuthenticationService.Instance.SignInWithUsernamePasswordAsync(username, password);
            Debug.Log("SignIn is successful.");

            

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        catch (AuthenticationException ex)
        {
            // Compare error code to AuthenticationErrorCodes
            // Notify the player with the proper error message
            Debug.LogException(ex);
        }
        catch (RequestFailedException ex)
        {
            // Compare error code to CommonErrorCodes
            // Notify the player with the proper error message
            Debug.LogException(ex);
        }
    }

    public void AlreadyHaveAccount()
    {
        signUp.SetActive(false);
        signIn.SetActive(true);
        alreadyHave.SetActive(false);
        dontHave.SetActive(true);
    }

    public void DontHaveAccount()
    {
        signIn.SetActive(false);
        signUp.SetActive(true);
        alreadyHave.SetActive(true);
        dontHave.SetActive(false);
    }
}
