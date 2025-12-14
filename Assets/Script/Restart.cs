using UnityEngine;
using UnityEngine.UI;

public class RestartButton : MonoBehaviour
{
    public GameObject restartButton;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            // ボールがUnderBlockに衝突したらリスタートボタンを表示する
            restartButton.SetActive(true);

            Time.timeScale = 0.0f;
        }
    }
}