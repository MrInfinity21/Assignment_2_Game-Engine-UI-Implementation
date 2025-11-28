using UnityEngine;

public class InteractPop : MonoBehaviour, IInteractable
{

    [SerializeField] private GameObject _canvas;
    

    private void Start()
    {
        _canvas.SetActive(false);
    }

    public void Interact()
    {
        _canvas.SetActive(!_canvas.activeSelf);
    }

}
