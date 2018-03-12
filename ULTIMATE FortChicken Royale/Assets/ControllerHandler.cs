using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerHandler : MonoBehaviour {

    public string[] controllers2 = new string[8];

    public int controllerNumber;
    int offsetFactor = 20;

    string Square;
    string X;
    string Circle;
    string Triangle;

    string R1;
    string R2;
    string L1;
    string L2;

    string Share;
    string Pad;
    string Options;
    string PS;

    string RightStickX;
    string RightStickY;
    string LeftStickX;
    string LeftStickY;
    string DPadX;
    string DPadY;

    bool inputSquare;
    bool inputX;
    bool inputCircle;
    bool inputTriangle;

    bool inputR1;
    bool inputR2;
    bool inputL1;
    bool inputL2;

    bool inputShare;
    bool inputPad;
    bool inputOptions;
    bool inputPS;

    float inputRightStickX;
    float inputRightStickY;
    float inputLeftStickX;
    float inputLeftStickY;
    float inputDPadX;
    float inputDPadY;

    // Use this for initialization
    void Start ()
    {
        //foreach (string joy in Input.GetJoystickNames()) Debug.LogError(joy);

        Square = "C" + controllerNumber + "Square";
        X = "C" + controllerNumber + "X";
        Circle = "C" + controllerNumber + "Circle";
        Triangle = "C" + controllerNumber + "Triangle";

        L1 = "C" + controllerNumber + "L1";
        L2 = "C" + controllerNumber + "L2";
        R1 = "C" + controllerNumber + "R1";
        R2 = "C" + controllerNumber + "R2";

        Share = "C" + controllerNumber + "Share";
        Pad = "C" + controllerNumber + "Pad";
        Options = "C" + controllerNumber + "Options";
        PS = "C" + controllerNumber + "PS";

        RightStickX = "C" + controllerNumber + "RightStickX";
        RightStickY = "C" + controllerNumber + "RightStickY";
        LeftStickX = "C" + controllerNumber + "LeftStickX";
        LeftStickY = "C" + controllerNumber + "LeftStickY";
        DPadX = "C" + controllerNumber + "DPadX";
        DPadY = "C" + controllerNumber + "DPadY";
    }

    void ReadInputs()
    {
        inputSquare = Input.GetButton(Square);
        inputX = Input.GetButton(X);
        inputCircle = Input.GetButton(Circle);
        inputTriangle = Input.GetButton(Triangle);

        inputL1 = Input.GetButton(L1);
        inputL2 = Input.GetButton(L2);
        inputR1 = Input.GetButton(R1);
        inputR2 = Input.GetButton(R2);

        inputShare = Input.GetButton(Share);
        inputPad = Input.GetButton(Pad);
        inputOptions = Input.GetButton(Options);
        inputPS = Input.GetButton(PS);

        inputRightStickX = Input.GetAxis(RightStickX);
        inputRightStickY = Input.GetAxis(RightStickY);
        inputLeftStickX = Input.GetAxis(LeftStickX);
        inputLeftStickY = Input.GetAxis(LeftStickY);
        inputDPadX = Input.GetAxis(DPadX);
        inputDPadY = Input.GetAxis(DPadY);
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        ReadInputs();
        controllers2 = Input.GetJoystickNames();

        //Debug.Log(Input.GetAxis("C3RightStickY"));

        GameObject.Find(this.gameObject.name + "/Square").GetComponent<Image>().enabled = inputSquare;
        GameObject.Find(this.gameObject.name + "/X").GetComponent<Image>().enabled = inputX;
        GameObject.Find(this.gameObject.name + "/Circle").GetComponent<Image>().enabled = inputCircle;
        GameObject.Find(this.gameObject.name + "/Triangle").GetComponent<Image>().enabled = inputTriangle;

        GameObject.Find(this.gameObject.name + "/L1").GetComponent<Image>().enabled = inputL1;
        GameObject.Find(this.gameObject.name + "/L2").GetComponent<Image>().enabled = inputL2;
        GameObject.Find(this.gameObject.name + "/R1").GetComponent<Image>().enabled = inputR1;
        GameObject.Find(this.gameObject.name + "/R2").GetComponent<Image>().enabled = inputR2;

        GameObject.Find(this.gameObject.name + "/Share").GetComponent<Image>().enabled = inputShare;
        GameObject.Find(this.gameObject.name + "/Pad").GetComponent<Image>().enabled = inputPad;
        GameObject.Find(this.gameObject.name + "/Options").GetComponent<Image>().enabled = inputOptions;
        GameObject.Find(this.gameObject.name + "/PS").GetComponent<Image>().enabled = inputPS;

        GameObject.Find(this.gameObject.name + "/RightStick/Knob").transform.localPosition = new Vector3(inputRightStickX*offsetFactor, inputRightStickY*offsetFactor, 0);
        GameObject.Find(this.gameObject.name + "/LeftStick/Knob").transform.localPosition = new Vector3(inputLeftStickX * offsetFactor, inputLeftStickY * offsetFactor, 0);
        GameObject.Find(this.gameObject.name + "/DPad/Knob").transform.localPosition = new Vector3(inputDPadX * offsetFactor, inputDPadY * offsetFactor, 0);
    }
}
