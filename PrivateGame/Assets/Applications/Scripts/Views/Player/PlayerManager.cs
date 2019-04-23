using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// キャラクターマネージャ
/// </summary>
public class PlayerManager : MonoBehaviour {

    private bool isMove;
    private Joycon joyconLeft;      //左
    private Joycon joyconRight;     //右

	// Use this for initialization
	void Start () {
        List<Joycon> joycon = JoyconManager.Instance.j;

        foreach (Joycon j in joycon) {
            if (j.isLeft){
                joyconLeft = j;
            }
            else{
                joyconRight = j;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(joyconLeft.GetStick()[0] * -1, 0, joyconLeft.GetStick()[1] * -1);
	}
}
