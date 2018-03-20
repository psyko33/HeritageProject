using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "USBObject_", menuName = "New USB")]

public class USB_Scriptable : ScriptableObject
{

    [Header("Generic")]
    public string USB_Name;
    public string Scenario_Text;

    public void Print ()
    {
       // Debug.Log(Scenario_Text);
    }
   
}
