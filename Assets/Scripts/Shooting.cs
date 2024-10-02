using System;

public class Shooting : Activator
{
    public event Action Fired;

    protected override void OnButtonClick() =>
        Fired?.Invoke();
}
