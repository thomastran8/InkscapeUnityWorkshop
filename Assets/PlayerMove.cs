using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    private Rigidbody2D rb;
    [SerializeField]
    private float moveSpeed;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
	}

    void FixedUpdate () {
        rb.velocity = new Vector2(0, rb.velocity.y) + Vector2.right * moveSpeed;
	}
}
