using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableObject : MonoBehaviour
{
    public GameObject commandMenu;
    public Transform Reposition;
    public ui_manager ui_manager;
    public Text dialogFenster;
    public string inspectText;
    public SpriteRenderer sr;
    public Image img;
    public Sprite pic; 
     
    // Erster Frame des Objektes in der Szene
    public void Start()
    {

    }

    // Diese Funktion wird jeden Frame aufgerufen
    public void Update()
    {

    }

    
    public void OnMouseDown()
    {
        commandMenu.active = true;
        commandMenu.transform.position = transform.position;
        ui_manager.activeIO = this;
        ///dialogFenster.text = inspectText;
    }
}
