using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI shapeName;
    [SerializeField] TMP_InputField nameInput;    

    BaseShape baseShape;

    private void Start()
    {
        baseShape = FindObjectOfType<BaseShape>();
    }

    public void Greeting()
    {
        baseShape.Greeting();
    }

    public void Jump()
    {
        baseShape.Jump();
    }

    public void NameShape()
    {
        baseShape.m_shapeName = nameInput.textComponent.text;
        shapeName.text = $"Shape Selected : {baseShape.m_shapeName}";
    }
}
