using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderShape : BaseShape
{
    public override void Greeting()
    {
        base.Greeting();
        Debug.Log("By the way, weather is really great today!");
    }

}
