using TMPro;
using UnityEngine;

public class FadeOff : MonoBehaviour
{

    private bool _isActive;
    [SerializeField]
    private TMP_Text _text;
    [SerializeField]
    private float _speed = 0.5f;
    private float _countDown = 3;
    

    private void OnEnable()
    {
        _isActive = true;
        _countDown = 3f;
        _text.alpha = 1;
    }

    void Update()
    {

        if (_isActive)
        {
            _countDown -= Time.deltaTime;

            if (_countDown < 0)
            {
                _text.alpha -= Time.deltaTime * _speed;
                {
                    if (_text.alpha < 0)
                    {
                        gameObject.SetActive(false);

                    }

                }


            }
        }
    }
    
}
