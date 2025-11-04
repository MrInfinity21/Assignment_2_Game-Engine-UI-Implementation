using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class TextColorSwap : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [Header("Text Component")]
    [SerializeField] private TextMeshProUGUI _buttonText;

    [Header("Text Colors")]
    [SerializeField] private Color _normalColor = Color.white;
    [SerializeField] private Color _hoverColor = Color.yellow;

    private void Awake()
    {
        if (_buttonText == null)
        {
            _buttonText = GetComponentInChildren<TextMeshProUGUI>();
        }
            
        _buttonText.color = _normalColor;
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _buttonText.color = _hoverColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _buttonText.color = _normalColor;
    }


}
