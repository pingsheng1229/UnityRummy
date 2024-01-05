using UnityEngine;

public class Card : MonoBehaviour
{
    // 牌的數字
    public int number;

    // 牌的花色
    public CardSuit suit;

    // 在遊戲開始時執行的方法
    void Start()
    {
        // 在這裡添加需要在遊戲開始時執行的邏輯
    }

    // 在每個畫面更新時執行的方法
    void Update()
    {
        // 在這裡添加需要在每個畫面更新時執行的邏輯
    }
}

// 定義牌的花色
public enum CardSuit
{
    Hearts,
    Diamonds,
    Clubs,
    Spades
}
