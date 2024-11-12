using UnityEngine.SceneManagement;

namespace SceneSystem
{
    public class ReloadScene
    {
        public void RestartScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}