using UnityEngine;

public class MovingBlock : MonoBehaviour
{
    public float speed = 2f; // ブロックの速度

    // Update is called once per frame
    void Update()
    {
        // ブロックをx軸方向に動かす
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        // もしブロックが画面端に到達したら反転させる
        if (transform.position.x >= 16f || transform.position.x <= -16f)
        {
            speed *= -1;
        }
    }

    // ボールに当たった時の処理
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            // ブロックは壊れないので何もしない
        }
    }
}
