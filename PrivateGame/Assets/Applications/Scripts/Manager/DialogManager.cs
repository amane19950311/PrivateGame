//=================================================================
// DialogManager.cs
//
// ダイアログ管理マネージャ
//=================================================================

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ダイアログ管理マネージャ
/// </summary>
public class DialogManager : SingletonMonoBehaviour<DialogManager> {

    [SerializeField]
    private Transform root;

    [SerializeField]
    private Image backgroundImage;

    /// <summary>
    /// ダイアログ生成
    /// </summary>
    /// <param name="dialog">Dialog.</param>
    public void Create(GameObject dialog){
        Instantiate(dialog,root);
    }
}
