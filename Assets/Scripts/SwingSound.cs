using UnityEngine;

// 1m 前を、左右に行ったり来たり。音が左右に振れる
public class SwingSound : MonoBehaviour
{
    public float width = 2f;   // 左右に動く幅（m）
    public float speed = 1f;   // 速さ（m／秒）

    void Update()
    {
        // PingPong：0 〜 width を行ったり来たり
        float x = Mathf.PingPong(Time.time * speed, width) - width / 2f;
        float y = Camera.main.transform.position.y;
        transform.position = new Vector3(x, y, 1f);
    }
}
