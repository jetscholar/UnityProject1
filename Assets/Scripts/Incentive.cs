using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Incentive : MonoBehaviour
{

    private Rigidbody2D _rb2d;

    void Awake() {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _rb2d.position = new Vector2(Random.Range(-4.0f, 4.0f), Random.Range(-4.0f, 4.0f));
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        _rb2d.position = new Vector2(Random.Range(-4.0f, 4.0f), Random.Range(-4.0f, 4.0f));
    }
}
