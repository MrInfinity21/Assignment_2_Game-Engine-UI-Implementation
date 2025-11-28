using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] private float interactRange = 2f;
    [SerializeField] private LayerMask interactLayer;

    private IInteractable _currentInteract;

    private void Update()
    {
        DetectInteractable();

        if(Input.GetKeyDown(KeyCode.E)&& _currentInteract != null)
        {
            _currentInteract.Interact();
        }
    }

    private void DetectInteractable()
    {
        Collider[]hits = Physics.OverlapSphere(transform.position, interactRange, interactLayer);

        if(hits.Length > 0 )
        {
            _currentInteract = hits[0].GetComponent<IInteractable>();
        }
        else
        {
            _currentInteract = null;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, interactRange);
    }
}
