using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TapHandler : MonoBehaviour, IInputClickHandler, IFocusable
{
    bool isTapped = false;
    Color startColor;
    Renderer renderer;

    public void OnFocusEnter()
    {
        renderer = gameObject.GetComponent<Renderer>();
        startColor = renderer.material.color;
        renderer.material.color = Color.green;
    }

    public void OnFocusExit()
    {
        if (renderer != null)
        {
            renderer.material.color = startColor;
        }
    }

    public void OnInputClicked(InputEventData eventData)
    {
        isTapped = !isTapped;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (isTapped)
        {
            this.gameObject.transform.Rotate(Vector3.right * Time.deltaTime * 10);
        }

    }
}
