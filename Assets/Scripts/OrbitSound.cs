using UnityEngine;

// スキャンしたモノを、AR を始めた場所のまわりで回す。AudioSource（音像）も一緒に回る
public class OrbitSound : MonoBehaviour
{
    public float radius = 1.0f;   // 円の半径（m）
    public float speed  = 30f;    // 1秒に進む角度（度）。マイナスで逆回り
    public float height = 0f;     // 耳の高さからの上下（m）

    float angle = 0f;                // 今の角度（度）

    void Update()
    {
        angle += speed * Time.deltaTime;                        // 角度を少しずつ進める
        float rad = angle * Mathf.Deg2Rad;                      // 度 → ラジアン
        float y = Camera.main.transform.position.y + height;    // カメラ（耳）と同じ高さ
        transform.position = new Vector3(Mathf.Cos(rad) * radius, y, Mathf.Sin(rad) * radius);
    }
}
