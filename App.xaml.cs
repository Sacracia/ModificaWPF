﻿using ModificaWPF.Pages;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ModificaWPF
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void SettingsClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button settingsBtn)
            {
                SettingsPage page = (SettingsPage)Application.Current.FindResource("SettingsPage");
                page.SetConfig((UserModConfig)settingsBtn.Tag);
                AppLogic.Instance.MainNavigateTo<SettingsPage>();
            }
        }

        private void LoadModClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button loadBtn)
            {
                LoaderLogic.Instance.LoadCustomMod(loadBtn.Tag as UserModConfig);
            }
        }
    }
}
