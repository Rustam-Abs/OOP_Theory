using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIHelper : MonoBehaviour
{

    public Slider slider;

    public Bricks _activeSprite;
    [SerializeField]
    private GameObject _notice;
    [SerializeField]
    private TMP_Text _text;

    private void Awake()
    {
        _notice.SetActive(false);
    }

    public void SetActiveSprite(Bricks _sprite)
    {
        if (_activeSprite != null)
        { _activeSprite._activeIcon.enabled = false; }

        _activeSprite = _sprite;
        _activeSprite._activeIcon.enabled = true;
        slider.value = _activeSprite.speed;
      

    }
    public void SetSpeedFromSlider()
    {
        if(_activeSprite != null)
        _activeSprite.speed = slider.value;
        else
            ActivateNotice();

    }

    public void ChangeColorFromButton(Button _button)
    {
        if (_activeSprite != null)
            _activeSprite._image.color = _button.image.color;
        else
            ActivateNotice();
    }

    public void Action()
    {
        if (_activeSprite != null)
            _activeSprite.Action();
        else
            ActivateNotice();
    }


    private void ActivateNotice()
    {
        _notice.SetActive(true);
    }
}
