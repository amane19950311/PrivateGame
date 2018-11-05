using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class TitlePresenter : MonoBehaviour {

    private TitleModel model;

    [SerializeField]
    private ButtonComponent button;

    public void Initialize(TitleModel model){
        this.model = model;

        button.onClick.AsObservable()
              .Subscribe(_ => {
                  Debug.Log("Push");
              }).AddTo(gameObject);
    }

    public void Run(){

    }
}
