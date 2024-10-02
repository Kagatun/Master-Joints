using System;

public class Recharge : Activator
{
    public event Action Loaded;

    protected override void OnButtonClick() =>
        Loaded?.Invoke();
}
