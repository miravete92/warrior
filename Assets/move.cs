using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public int speedMultiplier = 1;

    public SpriteRenderer spriteRenderer;

    private float acceleration;

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Cosilla.variableGuay = 1;
    }

    // Update is called once per frame
    void Update()
    {
        float i = Input.GetAxis("Horizontal");
        print(i);

        transform.position = transform.position + Vector3.right * i * speedMultiplier * Time.deltaTime;

        animator.SetFloat("speed", Mathf.Abs(i));

        if (i < 0) spriteRenderer.flipX = true;
        else if (i > 0) spriteRenderer.flipX = false;
    }
}
