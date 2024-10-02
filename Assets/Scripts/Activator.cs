using UnityEngine;
using UnityEngine.UI;

public abstract class Activator : MonoBehaviour
{
    [SerializeField] private Button _actionButton;

    private void OnEnable()
    {
        _actionButton.onClick.AddListener(OnButtonClick);
    }

    private void OnDisable()
    {
        _actionButton.onClick.RemoveListener(OnButtonClick);
    }

    protected abstract void OnButtonClick();
}
