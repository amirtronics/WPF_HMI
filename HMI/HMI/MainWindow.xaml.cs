﻿using System.Windows;
using HMI.View;

namespace HMI;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public PLC beckhoffPLC;

    public MainWindow()
    {
        InitializeComponent();

        Attempt attempt = new Attempt();
        int a = attempt.AttemptFunc();

        beckhoffPLC = new PLC
        {
            adsAddress = "192.168.14.1.1.1",
            adsPort = 851,
        };
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        

        try
        {
            beckhoffPLC.Connect();
        }
        catch (Exception ex)
        {
            MessageBoxResult result = MessageBox.Show("Do you agree?", "Agreement",
            MessageBoxButton.YesNo, MessageBoxImage.Question);
        }
    }

    private void btnMinimize_Click(object sender, RoutedEventArgs e)
    {
        WindowState = WindowState.Minimized;
    }

    private void btnMaximize_Click(object sender, RoutedEventArgs e)
    {
        if (WindowState == WindowState.Maximized)
            WindowState = WindowState.Normal;
        else WindowState = WindowState.Maximized;
    }

    private void btnClose_Click(object sender, RoutedEventArgs e)
    {
        //Close();
        Application.Current.Shutdown();
    }

    private void btnStart_Click(object sender, RoutedEventArgs e)
    {

    }

    private void btnStop_Click(object sender, RoutedEventArgs e)
    {

    }

    private void btnReset_Click(object sender, RoutedEventArgs e)
    {

    }

    private void btnHome_Click(object sender, RoutedEventArgs e)
    {
        var mainWindow = Application.Current.MainWindow;

        // Iterate through all open windows and close them (excluding the current MainWindow)
        foreach (Window window in Application.Current.Windows)
        {
            if (window != mainWindow)
            {
                window.Close();
            }
        }
    }

    private void btnFlange_Click(object sender, RoutedEventArgs e)
    {
        FlangeWindow flangeWindow = new FlangeWindow();
        flangeWindow.Show();
    }

    private void btnProfile_Click(object sender, RoutedEventArgs e)
    {

    }

    private void btnCamera_Click(object sender, RoutedEventArgs e)
    {
        CameraWindow cameraWindow = new CameraWindow();
        cameraWindow.Show();
    }

    private void btnReconnect_Click(object sender, RoutedEventArgs e)
    {

    }
}