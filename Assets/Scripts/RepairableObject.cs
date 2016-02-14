﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RepairableObject : MonoBehaviour {
    public double Damage;
    public double BreakdownSpeed;
    public double Resistance;
    public bool canInteract;
    public string ObjectName;
    private bool DisplayName;
    public double RoundedDamage;
    public GameObject Popup;
    public Text output;
    

    // Use this for initialization
    void Start () {
        
        Damage = 0;
        canInteract = false;
	
	}
	
	// Update is called once per frame
	void Update () {
        DamageOverTime();
	
	}

    void OnMouseDown()
    {
        if (canInteract == true)
        {
            DisplayName = true;
            ShowPopup();
        }
        else
        {
            Popup.SetActive(false);
        }
     }
    void OnMouseExit()
    {
        
    }

    void OnGUI()
    {
        if (DisplayName == true)
        {
            GUI.Label(new Rect(0, 0, 100, 100), (ObjectName + "   damage:" + System.Convert.ToString(RoundedDamage)));
            
        }
    }

    void DamageOverTime()
    {
        Damage = Damage + BreakdownSpeed/(Resistance * 100);
        RoundedDamage = System.Math.Round(Damage, 2);

    }
    void Repair()
    {
        Damage = 0;
    }

    void ShowPopup()
    {
        Popup.SetActive(true);
        output.text = (ObjectName);

    }

    void OnTriggerEnter(Collider player)
    {
        canInteract = true;
    }
    void OnTriggerExit(Collider player)
    {
        canInteract = false;
        DisplayName = false;
    }

}
