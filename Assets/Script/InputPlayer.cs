using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPlayer : MonoBehaviour
{
    [HideInInspector] public float EjeHorizontal { get; private set; }
    [HideInInspector] public float EjeVertical {get; private set; }
    [HideInInspector] public bool Atacar {get; private set; }
    [HideInInspector] public bool Habilidad {get; private set; }
    [HideInInspector] public bool Habilidad1 {get; private set; }
    [HideInInspector] public bool Inventario {get; private set; }
    [HideInInspector] public bool Interactuar {get; private set; }


    // Update is called once per frame
    void Update()
    {
        Atacar = Input.GetButtonDown("Atacar");
        Habilidad = Input.GetButtonDown("Habilidad");
        Habilidad1 = Input.GetButtonDown("Habilidad1");
        Inventario = Input.GetButtonDown("Inventario");
        Interactuar = Input.GetButtonDown("Interactuar");
        EjeHorizontal = Input.GetAxis("Horizontal");
        EjeVertical = Input.GetAxis("Vertical");       
    }

}
