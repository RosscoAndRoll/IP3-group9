using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RepairableObject : MonoBehaviour {
    public GameObject Player;
    public double Damage;
    public double BreakdownSpeed;
    public double Resistance;
    public bool canInteract;
    public string ObjectName;
    private bool DisplayName;
    public double RoundedDamage;
    public GameObject Popup;
    public Text output;
    public GameObject lowDamage, mediumDamage, highDamage;
    

    // Use this for initialization
    void Start () {
        
        Damage = 0;
        canInteract = false;
        Popup.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
        if (Damage < 100)
        {
            DamageOverTime();
        }

        //Close popup on right click
        if (Input.GetMouseButtonDown(1))
        {
            Popup.SetActive(false);
        }
        
	
        
	}

    void OnMouseDown()
    {
        if (canInteract == true)
        {
            DisplayName = true;
            ShowPopup();
        }
        else if (canInteract == false)
        {
            
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

        if (Damage <= 25)
        {
            lowDamage.SetActive(true);
            mediumDamage.SetActive(false);
            highDamage.SetActive(false);
        }
        else if (Damage > 25 & Damage < 75)
        {
            lowDamage.SetActive(false);
            mediumDamage.SetActive(true);
            highDamage.SetActive(false);
        }
        else
        {
            lowDamage.SetActive(false);
            mediumDamage.SetActive(false);
            highDamage.SetActive(true);
        }

    }
    public void Repair()
    {
        if (canInteract == true)
         {
            this.Damage = 0;
        }
    }

    void ShowPopup()
    {
        Popup.SetActive(true);
        output.text = (ObjectName);

    }

    void OnTriggerStay (Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            canInteract = true;
        }

        
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canInteract = false;
            DisplayName = false;
        }

    }

}
