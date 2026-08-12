using System;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AvaloniaIssues.Views;

namespace AvaloniaIssues;

public class App : Application
{
    public override void Initialize() => AvaloniaXamlLoader.Load(this);

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            desktop.MainWindow = new MainWindow();

        base.OnFrameworkInitializationCompleted();
    }

    private void Active() =>
        (ApplicationLifetime as IClassicDesktopStyleApplicationLifetime)!.MainWindow!.Activate();

    private void TrayIcon_Clicked(object? sender, EventArgs e) => Active();

    private void NativeMenuItem_Click(object? sender, EventArgs e) => Active();

    private void NativeMenuItem2_Click(object? sender, EventArgs e) =>
        Dispatcher.InvokeAsync(Active);
}
