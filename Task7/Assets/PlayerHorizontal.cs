using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerHorizontal : MonoBehaviour, IDragHandler
{
    public Transform player0;
    public Transform player1;
    public float mouseSensivity;
    public void OnDrag(PointerEventData eventData)
    {
        Vector3 pos = player0.position;
        pos.x = Mathf.Clamp(pos.x + (eventData.delta.x / mouseSensivity), 0, 4);
        player0.position = new Vector3(pos.x, player0.position.y, pos.z);
        player1.position = new Vector3(-pos.x, player1.position.y, -pos.z);
    }
}
