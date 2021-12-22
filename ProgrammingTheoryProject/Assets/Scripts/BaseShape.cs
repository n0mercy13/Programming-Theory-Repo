using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseShape : MonoBehaviour
{
    [SerializeField] protected float jumpForce;
    private string shapeName = "Nobody";
    public string m_shapeName
    {
        get { return shapeName; }
        set 
        { 
            if(value.Length >= 3 && value.Length <= 8)
            {
                shapeName = value;
            }
            else
            {
                Debug.LogWarning("Shape name lengh from 3 to 8 characters.");
            }
        }
    }
    public GameObject shapeSelected { get; private set; }

    private Rigidbody shapeRb;

    void Start()
    {
        shapeRb = GetComponent<Rigidbody>();
    }

    private void OnMouseDown()
    {
        shapeSelected = gameObject;
        Debug.Log(shapeSelected.GetComponent<BaseShape>().shapeName);
    }
    public virtual void Greeting()
    {
        Debug.Log($"Hello, my name is {shapeName}");        
    }

    public virtual void Jump()
    {       
        shapeRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        Debug.Log($"{shapeName} is jumping!");        
    }

    

    

   
}
