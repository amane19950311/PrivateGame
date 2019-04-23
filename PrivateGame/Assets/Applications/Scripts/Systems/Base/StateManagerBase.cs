using System.Collections;

public enum BaseState
{
    Start,
    Prepare,
    Playing,
    End
}

/// <summary>
/// ステート管理基底クラス
/// </summary>
public abstract class StateManagerBase : SingletonMonoBehaviour<StateManagerBase> {

    protected BaseState state;

    // 外からこのメソッドを使って状態を変更
    public void SetCurrentState(BaseState state)
    {
        this.state = state;
        OnStateChanged(this.state);
    }

    // 状態が変わったら何をするか
    protected void OnStateChanged(BaseState state)
    {
        switch (state)
        {
            case BaseState.Start:
                StartAction();
                break;
            case BaseState.Prepare:
                StartCoroutine(PrepareCoroutine());
                break;
            case BaseState.Playing:
                PlayingAction();
                break;
            case BaseState.End:
                EndAction();
                break;
            default:
                break;
        }
    }

    // Startになったときの処理
    protected virtual void StartAction()
    {
    }

    // Prepareになったときの処理
    protected virtual IEnumerator PrepareCoroutine()
    {
        SetCurrentState(BaseState.Playing);
        yield return null;
    }
    // Playingになったときの処理
    protected virtual void PlayingAction()
    {
       
    }
    // Endになったときの処理
    protected virtual void EndAction()
    {
    }

}
