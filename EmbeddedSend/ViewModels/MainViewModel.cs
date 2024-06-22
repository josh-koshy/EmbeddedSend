// "(C) 2024 Joshua Koshy."

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EmbeddedSend.Views;

namespace EmbeddedSend.ViewModels
{
    public class MainViewModel : ObservableObject
    {
		private string _testString = "Hello, World.";
        private int _testStringInt = 0;
		public ICommand ButtonPress { get; }
        public ICommand SettingsMenuPress { get; }
        public ICommand AboutMenuPress { get; }

        public MainViewModel()
        {
            ButtonPress = new RelayCommand(IncrementHelloWorldNumber);
            SettingsMenuPress = new RelayCommand(OnSettingsMenuPress);
            AboutMenuPress = new RelayCommand(OnAboutMenuPress);
        }



        public void OnSettingsMenuPress()
        {
            Debug.WriteLine("Settings Menu Pressed.");
            SettingsWindow settingsWindow = new SettingsWindow();
            settingsWindow.ShowDialog();
        }
        public void OnAboutMenuPress()
        {
            Debug.WriteLine("About Menu Pressed");
        }
        private void IncrementHelloWorldNumber()
        {
            _testStringInt++;
            TestString = $"Hello, World. I have been pressed {_testStringInt} times.";
        }
        public string TestString
		{
			get { return _testString; }
			set { SetProperty(ref _testString, value); }
		}

	}
}
