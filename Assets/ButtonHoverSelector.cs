using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHoverSelector : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler
{
    public EventSystem eventSystem; // Referenz auf das EventSystem

    private void Start()
    {
        // Setze den Fokus auf den ersten Button zu Beginn
        if (eventSystem != null)
        {
            eventSystem.SetSelectedGameObject(gameObject);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Setze den aktuell ausgew�hlten Button, wenn die Maus �ber den Button schwebt
        eventSystem.SetSelectedGameObject(gameObject);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Hier geschieht nichts, um den Button weiterhin ausgew�hlt zu lassen
    }

    public void OnSelect(BaseEventData eventData)
    {
        // Hier kannst du optional etwas tun, wenn der Button ausgew�hlt wird
    }

    public void OnDeselect(BaseEventData eventData)
    {
        // Hier geschieht nichts, um sicherzustellen, dass der Button ausgew�hlt bleibt
    }
}
