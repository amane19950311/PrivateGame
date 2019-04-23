using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitlePanel : MonoBehaviour {

    [SerializeField]
    private TitlePresenter presenter;

	// Use this for initialization
	void Start () {
        SceneManager.LoadScene("System", LoadSceneMode.Additive);
        presenter.Initialize(new TitleModel());
	}

}
