using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.XR.Interaction.Toolkit.Inputs;
using UnityEngine.Assertions;

public class pos : MonoBehaviour
{
    //Start is called before the first frame update
    void Start()
    {

    }

    public Transform xrOrigin;
    public Text text;

    //Update is called once per frame
    void Update()
    {

        text.text = xrOrigin.position.ToString();
    }
}
