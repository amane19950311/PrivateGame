using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UniRx.Triggers;
using DG.Tweening;

/// <summary>
/// 入力アクションPresenter
/// </summary>
public class ActionPresenter : MonoBehaviour
{
    [SerializeField]
    private RectTransform lineTransform;

    [SerializeField]
    private RectTransform rectTransform;

    [SerializeField]
    private Image notePrefab;

    [SerializeField]
    private Transform notesRoot;

    private List<GameObject> notesList = new List<GameObject>();
    private ActionModel model;

    public void Initialize(ActionModel model) {

        this.model = model;

    }

    public void Run() {

        lineTransform.DOAnchorPosX(-rectTransform.rect.width, model.Speed)
            .OnStepComplete(() => {
                lineTransform.anchoredPosition = Vector3.zero;

                foreach(GameObject note in notesList) {
                    Destroy(note);
                }
                notesList.Clear();
            })
            .SetEase(Ease.Linear)
            .SetLoops(-1);

        model.SendActionKey
            .Subscribe(type => {
                Image note = Instantiate(notePrefab, notesRoot);
                note.rectTransform.localPosition = new Vector3(lineTransform.localPosition.x, 0, 0);
                notesList.Add(note.gameObject);

            })
            .AddTo(this);
    }
}
