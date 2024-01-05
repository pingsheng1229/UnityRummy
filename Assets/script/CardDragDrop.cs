using UnityEngine;

public class CardDragDrop : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;

    // 在每個畫面更新時執行的方法
    void Update()
    {
        if (isDragging)
        {
            // 跟隨鼠標移動
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mousePosition.x + offset.x, mousePosition.y + offset.y, transform.position.z);
        }
    }

    // 當鼠標按下時執行的方法
    void OnMouseDown()
    {
        // 記錄拖曳起始點的偏移量
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        isDragging = true;
    }

    // 當鼠標釋放時執行的方法
    void OnMouseUp()
    {
        isDragging = false;
    }
}
