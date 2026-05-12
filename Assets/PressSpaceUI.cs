using UnityEngine;
using UnityEngine.UI;
public class PressSpaceUI : MonoBehaviour
{
    public RectTransform buttonRect;
    public float bounceAmount = 10f;
    public float bounceSpeed = 2f;

    private Vector2 _startPos;

    private void Start()
    {
        _startPos = buttonRect.anchoredPosition;
    }

    private void Update()
    {
        // Animate up and down
        float offset = Mathf.Sin(Time.time * bounceSpeed) * bounceAmount;
        buttonRect.anchoredPosition = _startPos + Vector2.up * offset;
    }
}