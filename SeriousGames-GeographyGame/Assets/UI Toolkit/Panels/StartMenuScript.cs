using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI_Toolkit.Panels
{
    public class StartMenuScript : MonoBehaviour
    {
        private void Start()
        {
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }

        public void StartGame()
        {
            StartCoroutine(StartGameCo());
        }

        public void QuitGame()
        {
            StartCoroutine(QuitGameCo());
        }
    
        // ReSharper disable Unity.PerformanceAnalysis
        private static IEnumerator StartGameCo()
        {
            Debug.Log("Loading: Next Scene");
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Debug.Log("Loaded: Next Scene");
        }

        // ReSharper disable Unity.PerformanceAnalysis
        private static IEnumerator QuitGameCo()
        {
            Debug.Log("Quitting: Application");
            yield return new WaitForSeconds(1f);
            Application.Quit();
            Debug.Log("Quited: Application");
        }
    }
}
