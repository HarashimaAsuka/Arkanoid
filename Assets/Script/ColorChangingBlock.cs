using UnityEngine;

public class ColorChangingBlock : MonoBehaviour
{
    public Color hitColor1 = Color.red; // 当たったときの色1
    public Color hitColor2 = Color.blue; // 当たったときの色2
    public LayerMask ballLayer; // ボールのレイヤー

    private Color originalColor; // 元の色
    private Renderer blockRenderer;
    private bool isColor1 = true; // 現在の色が色1かどうかのフラグ

    // Start is called before the first frame update
    void Start()
    {
        // ブロックのレンダラーを取得
        blockRenderer = GetComponent<Renderer>();
        // ブロックの元の色を保存
        originalColor = blockRenderer.material.color;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (ballLayer == (ballLayer | (1 << collision.gameObject.layer)))
        {
            // ボールが当たったら色を変える
            if (isColor1)
            {
                ChangeColor(hitColor1);
                isColor1 = false;
            }
            else
            {
                ChangeColor(hitColor2);
                isColor1 = true;
            }
        }
    }

    private void ChangeColor(Color newColor)
    {
        blockRenderer.material.color = newColor;
    }

    public void ResetColor()
    {
        // ブロックの色を元に戻す
        blockRenderer.material.color = originalColor;
        isColor1 = true;
    }
}
