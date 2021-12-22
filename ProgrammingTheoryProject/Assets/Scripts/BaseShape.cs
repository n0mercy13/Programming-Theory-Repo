using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseShape : MonoBehaviour
{
    [SerializeField] protected float moveForce;
    protected string shapeName;
    protected bool isSelected = false;
    protected bool isMoving = false;
    

    private Rigidbody shapeRb;

    void Start()
    {
        shapeRb = GetComponent<Rigidbody>();
    }

    public virtual void Greeting()
    {
        Debug.Log($"Hello, my name is {shapeName}");        
    }

    public virtual void Move()
    {
        if(isMoving) isMoving = false;
        if(!isMoving)
        {
            isMoving = true;
            shapeRb.AddForce(Vector3.up * moveForce, ForceMode.Impulse);
            Debug.Log($"{shapeName} is jumping!");
        }
    }

    

    

   
}
