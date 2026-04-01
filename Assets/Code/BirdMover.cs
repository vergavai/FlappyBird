using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BirdMover : MonoBehaviour
{
    [SerializeField] private Vector3 _startPosition;
    [SerializeField] private float _speed;
    [SerializeField] private float _tapForce = 10f;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _rotationOnInputZ;
    [SerializeField] private float _constantRotationZ;
    
    private Quaternion _rotationOnInput;
    private Quaternion _constantRotation;
    
    private Rigidbody2D _rigidbody;
    
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        transform.position = _startPosition;
    }

    private void Start()
    {
        _rotationOnInput = Quaternion.Euler(0, 0, _rotationOnInputZ);
        _constantRotation = Quaternion.Euler(0, 0, _constantRotationZ);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.rotation = _rotationOnInput;
            _rigidbody.velocity = new Vector2(_speed, _tapForce);
        }
        
        transform.rotation = Quaternion.Lerp(transform.rotation, _constantRotation, _rotationSpeed * Time.deltaTime);
    }

    public void ResetBird()
    {
        transform.position = _startPosition;
        transform.rotation = Quaternion.Euler(Vector3.zero);
        _rigidbody.velocity = Vector2.zero;
    }
}
