using UnityEngine;
using UnityEngine.Events;

public class NotesLimit : MonoBehaviour
{
[SerializeField]
private UnityEvent onNotesLimitReached;
private void OnTriggerEnter2D(Collider2D colliision)
    {
        if (colliision.CompareTag("Note"))
        {
            onNotesLimitReached?.Invoke();
            Destroy(colliision.gameObject);
        }
    }
}
