using UnityEngine;
using UnityEngine.SceneManagement;

namespace Snake_Case
{
public class ButtonWork_snake_case : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PrevScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
}
