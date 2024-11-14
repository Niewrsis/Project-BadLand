using UnityEngine.SceneManagement;

namespace SceneSystem
{
    public class ReloadScene
    {
        public static void RestartScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}