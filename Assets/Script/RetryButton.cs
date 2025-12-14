using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{
    public void OnRetryButtonClick(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        if(Time.timeScale == 0.0f){
            Time.timeScale = 1.0f;
        }
    }
}
