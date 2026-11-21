using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// マウスポインター
/// --------------------------------------------------
/// |・マウスの座標に合わせて動く                    |
/// --------------------------------------------------
/// </summary>
public class MoucePointer : MonoBehaviour
{
  
    void Start()
    {
        
    }



    void Update()
    {
        Movement();         //移動の実行
    }

   public void Movement()
    {
        // マウスの座標を取得
        Vector2 moucePosition = Mouse.current.position.value;

        //スクリーン座標系を作る
        Vector3 screenPosition = moucePosition;
        screenPosition.z = 10;

        // マウスの座標をワールド座標に変換する
        // ワールド座標系 = Camera.ScreenToWorldPoint( スクリーン座標)
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);

        // オブジェクトの座標をマウスと合わせる
        transform.position = worldPosition;
    }
}
