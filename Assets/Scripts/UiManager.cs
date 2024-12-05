using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class UiManager : MonoBehaviour
{
    [SerializeField] private Button _backBtn;
    [SerializeField] private Button _quitBtn;
    [SerializeField] private GameObject _popupPanel; 
    [SerializeField] private GameObject _displayPanel; 

    void Start()
    {
        _backBtn.onClick.AddListener(HidePopup);
    }

    public void ShowPopup()
    {
        _displayPanel.SetActive(false);
        _popupPanel.SetActive(true);
        _popupPanel.transform.DOScale(1f,1f);
    }

    public void HidePopup()
    {
        _popupPanel.transform.DOScale(0f,1f);
        _popupPanel.SetActive(false);
        _displayPanel.SetActive(true);
    }

    private void QuitApp()
    {
        Application.Quit();
    } 
}
