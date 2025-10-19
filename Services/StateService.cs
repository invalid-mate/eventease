namespace EventEase.Services;

public class StateService
{
    private string _currentTheme = "light";

    public event Action? OnChange;

    public string CurrentTheme
    {
        get => _currentTheme;
        set
        {
            if (_currentTheme != value)
            {
                _currentTheme = value;
                NotifyStateChanged();
            }
        }
    }

    public void ToggleTheme()
    {
        CurrentTheme = CurrentTheme == "light" ? "dark" : "light";
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}
