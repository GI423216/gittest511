using UnityEngine;

public class testmove : MonoBehaviour
{
    public float speed = 5.0f; // 移動速度

    void Update()
    {
        // 入力の取得 (A/D, 左/右)
        float moveH = Input.GetAxis("Horizontal");
        // 入力の取得 (W/S, 上/下)
        float moveV = Input.GetAxis("Vertical");

        // 移動方向のベクトルを作成
        Vector3 movement = new Vector3(moveH, 0, moveV);

        // オブジェクトを移動させる
        // Time.deltaTimeを掛けることで、PCのフレームレートに関わらず一定の速度になります
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
