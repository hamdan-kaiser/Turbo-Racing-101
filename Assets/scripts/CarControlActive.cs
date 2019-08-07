using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarControlActive : MonoBehaviour
{

    public GameObject CarControl;
    public GameObject CarControl2;
    public GameObject CarControl3;
    public GameObject CarControl4;
    // Start is called before the first frame update
    void Start()
    {
        CarControl.GetComponent<CarController>().enabled = true;
        CarControl2.GetComponent<CarController>().enabled = true;
        CarControl3.GetComponent<CarController>().enabled = true;
        CarControl4.GetComponent<CarController>().enabled = true;

    }

    
}
