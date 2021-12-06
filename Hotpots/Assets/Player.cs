using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // 如果想要在 inspector 也可以設定，就把它變成 public
    // 移動速度
    public float moveSpeed = 5f;  
    
    // 如果想要他是 private 但是有想要在 inspector 可以看到他可以寫 [SerializeField]
    [SerializeField] float test;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(123);
        // transform 是 inspector 裡面的屬性，可以使用應該是因為
        // 掛載到物件上面，所以就可以有這個屬性了

        // Translate 要帶三個值 x, y, z
        transform.Translate(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // 每個人電腦執行速度不一樣
        // PC1 每秒可以執行 1000 次 (0.01 * 1000 = 10)
        // PC2 每秒可以執行 100 次 (0.01 * 100 = 1)
        // 一個一秒鐘可以跑 10 格，一個一秒鐘可以跑 1 格，這樣就有問題了
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
        // Time.deltaTime 是此次更新與前一次更新時間的差
        // 因此，假設我的電腦 每秒可以更新兩個影格，另外一台電腦是每秒更新一個影格
        // PC1 -> 1 (秒) * 2 (兩影格) * 0.5 (delta) = 1
        // PC2 -> 1 (秒) * 1 (一影格) * 1 (delta) = 1
        // 如此一來就不會有兩台電腦刷新頻率的問題
        
    }
}
