using UnityEngine;

public class Block : MonoBehaviour
{
    public AudioClip hitSound; // ボールがブロックに当たった時に鳴らす音
    private AudioSource audioSource; // 音を鳴らすための AudioSource コンポーネント

    private void Start()
    {
        // AudioSource コンポーネントを取得する
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            // AudioSource コンポーネントがアタッチされていない場合は追加する
            audioSource = gameObject.AddComponent<AudioSource>();
        }
        // ヒット音の設定
        audioSource.clip = hitSound;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // 衝突したオブジェクトがボールであり、かつブロックに "Block" タグが付いている場合
        if (collision.gameObject.CompareTag("Ball"))
        {
            // 音を再生する
            if (hitSound != null && audioSource != null)
            {
                audioSource.Play();
            }

            // ブロックを破壊する
            Destroy(gameObject);
        }
    }
}
