using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ActionNoteType {

    Type1 = 0,
    Type2,
    Type3,
    Type4
}

public class ActionManager : MonoBehaviour
{

    [SerializeField]
    private int bpm = 1;

    [SerializeField]
    private ActionPresenter presenter;
    private ActionModel model;

    // Start is called before the first frame update
    private void Start()
    {

        // ゲージが端まで行く時間を計算
        float speed = (60f / (float)bpm) * 4;

        model = new ActionModel(speed);

        presenter.Initialize(model);
        presenter.Run();
    }


    public void TestButton(int type) {

        model.SetNotes((ActionNoteType)type);
    }
}
