using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed;
    private float distance;

    private new Rigidbody rigidbody;

    public void Init(in float speed, in float distance)
    {
        this.speed = speed;
        this.distance = distance;
    }
   
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        Destroy(gameObject, distance);
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddForce(speed*Time.deltaTime*Vector3.right, ForceMode.Impulse);
    }
}
