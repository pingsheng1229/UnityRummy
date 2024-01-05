using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

     // 玩家的手牌
    private List<Card> hand;

    // 玩家的分數
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        // 初始化手牌和分數
        hand = new List<Card>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 添加卡牌到手牌
    public void AddCardToHand(Card card)
    {
        hand.Add(card);
    }

    // 從手牌中移除卡牌
    public void RemoveCardFromHand(Card card)
    {
        hand.Remove(card);
    }

    // 獲取玩家的手牌
    public List<Card> GetHand()
    {
        return hand;
    }

    // 獲取玩家的分數
    public int GetScore()
    {
        return score;
    }

    // 設定玩家的分數
    public void SetScore(int newScore)
    {
        score = newScore;
    }
}
