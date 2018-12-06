using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonHandler : MonoBehaviour, IPointerEnterHandler, IDeselectHandler {
    // Use this for initialization
    void Start() {
    }

    // Update is called once per frame
    void Update() {
    }

    public void OnPointerEnter(PointerEventData eventData) {
        GetComponent<Selectable>().Select();
    }


    public void OnDeselect(BaseEventData eventData) {
        GetComponent<Selectable>().OnPointerExit(null);
    }
}