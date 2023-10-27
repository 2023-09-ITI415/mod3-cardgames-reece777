using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene(string __Prospector)
    {
        SceneManager.LoadScene(__Prospector);
    }
}