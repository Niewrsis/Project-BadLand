using UnityEngine.SceneManagement;

namespace SceneSystem
{
    public static class ReloadScene
    {
        public static void RestartScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}