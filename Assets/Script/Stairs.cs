using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Stairs : MonoBehaviour    
{
    private Collider2D myCollider;
    public UnityEvent OnInteraction;

    private void Start()
    {
        myCollider = GetComponent<Collider2D>();   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        OnInteraction?.Invoke();
    }

}
