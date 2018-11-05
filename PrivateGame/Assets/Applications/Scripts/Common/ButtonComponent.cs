using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class ButtonComponent : Button {

    private Subject<Button> button = new Subject<Button>();
    public IObservable<Button> _Button { get { return button; }}

	// Use this for initialization
	void Start () {
        
	}
	
}
