using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.XR.Interaction.Toolkit.Inputs;
using UnityEngine.Assertions;
using System.Text;

using System.IO;

using System;

//public Transform xrOrigin;

//public Transform MainCamera;

public class txtScript : MonoBehaviour
{

    //public Transform mainCamera;

    void Start()
    {
        //Transform xrOrigin;
        Text txtmy = GameObject.Find("Canvas/Text").GetComponent<Text>();
        txtmy.text = "The text has changed";
    }

    void Update()
    {
        //Text location = GameObject.Find("Canvas/Text").GetComponent<TextReader>();

        //transform.position = center.position + new Vector3(x, 0, y));

        //location.text = (transform.position).toString();

        Text location = GameObject.Find("Canvas/Text").GetComponent<Text>();
        location.text = (Camera.main.transform.position.x + " ," + Camera.main.transform.position.y + " ," + Camera.main.transform.position.z);

    }

}