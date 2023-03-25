using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityTutorial : MonoBehaviour
{
    public float  kecepatan;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(-(kecepatan), 0f);
    }
}
