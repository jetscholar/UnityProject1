using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float _movementSpeed = 5.0f;

    private Rigidbody2D _rb2d;

    void Awake() {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _rb2d.position = new Vector2(0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow)) {
            _rb2d.position += Vector2.left * _movementSpeed * Time.deltaTime;
        } else if(Input.GetKey(KeyCode.RightArrow)) {
            _rb2d.position += Vector2.right * _movementSpeed * Time.deltaTime;
        } else if(Input.GetKey(KeyCode.UpArrow)) {
            _rb2d.position += Vector2.up * _movementSpeed * Time.deltaTime;
        } else if(Input.GetKey(KeyCode.DownArrow)) {
            _rb2d.position += Vector2.down* _movementSpeed * Time.deltaTime;
        }
    }
}
