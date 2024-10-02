using System;

public class Rocking : Activator
{
    public event Action Swung;

    protected override void OnButtonClick() =>
        Swung?.Invoke();
}
