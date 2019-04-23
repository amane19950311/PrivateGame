using System.Collections.Generic;
using UniRx;

/// <summary>
/// 入力アクションModel
/// </summary>
public class ActionModel {

    public IObservable<float> Cursol { get { return cursol; } }
    private Subject<float> cursol = new Subject<float>();

    public IObservable<ActionNoteType> SendActionKey { get { return sendActionKey; } }
    private Subject<ActionNoteType> sendActionKey = new Subject<ActionNoteType>();

    private List<ActionNoteType> notesList = new List<ActionNoteType>();

    public float Speed { get; private set; }

    public ActionModel(float speed) {

        Speed = speed;

    }

    public void SetNotes(ActionNoteType type) {

        notesList.Add(type);

        sendActionKey.OnNext(type);
    }
}
