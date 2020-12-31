using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private InputPlayer inputJugador;
    private Transform transformada;
    private Rigidbody2D mRigidbody2D;
    private Animator animator;
    private SpriteRenderer mSprite;
    [SerializeField] public float velocidad = 3;    
    private float horizontal;
    private float vertical;       
    private bool ofLeft;
    int runHashCode;
    // Start is called before the fir st frame update
    void Start()
    {
        inputJugador = GetComponent<InputPlayer>();
        transformada = GetComponent<Transform>();
        mRigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        mSprite = GetComponent<SpriteRenderer>();
        runHashCode = Animator.StringToHash("Running");


    }

    void Update()
    {
        horizontal = inputJugador.EjeHorizontal;
        vertical = inputJugador.EjeVertical;            
        ofLeft = (horizontal > 0);

        DirectionRight();

        if (vertical != 0 || horizontal != 0)
        {
            SetXYAnimator();
            animator.SetBool(runHashCode, true);
        } else
        {
            animator.SetBool(runHashCode, false);
        }
    }

    private void DirectionRight()
    {
        if (ofLeft && Mathf.Abs(vertical) < Mathf.Abs(horizontal))
        {
            animator.SetBool("Left", ofLeft);
        }
    }

    private void SetXYAnimator()
    {
        animator.SetFloat("X", horizontal);
        animator.SetFloat("Y", vertical);
    }

    // Update is called once per frame
    void FixedUpdate()
    {       
     
        Vector2 vectorVelocidad = new Vector2(horizontal, vertical) * velocidad;
        mRigidbody2D.velocity = vectorVelocidad;
    }

    

}
