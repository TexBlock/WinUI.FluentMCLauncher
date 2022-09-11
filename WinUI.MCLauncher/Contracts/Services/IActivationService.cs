namespace WinUI.MCLauncher.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
