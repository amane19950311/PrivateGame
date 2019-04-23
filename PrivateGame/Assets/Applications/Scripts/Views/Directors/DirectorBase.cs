using UnityEngine;

public abstract class DirectorBase : MonoBehaviour
{
	[SerializeField]
	protected Animator animator;

	/// <summary>
	/// 開始
	/// </summary>
	public virtual void Run()
	{
		animator.SetTrigger("Run");
	}

	/// <summary>
	/// 終了
	/// </summary>
	public virtual void End()
	{
		animator.SetTrigger("End");
	}

	/// <summary>
	/// 中断
	/// </summary>
	public virtual void Pause()
	{
		animator.speed = 0;
	}

	/// <summary>
	/// 復帰
	/// </summary>
	public virtual void Resume()
	{
		animator.speed = 1;
	}
}
