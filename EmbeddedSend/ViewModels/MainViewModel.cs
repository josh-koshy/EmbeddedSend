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

namespace EmbeddedSend.ViewModels
{
    public class MainViewModel : ObservableObject
    {
		private string _testString = "Hello, World.";
        private int _testStringInt = 0;
		public ICommand ButtonPress { get; }
        public ICommand SettingsMenuPress { get; }
        public ICommand AboutMenuPress { get; }

        public EventHandler SettingsMenuEvent;
        public EventHandler AboutMenuEvent;

        protected void OnAboutMenu(EventArgs e)
        {
            AboutMenuEvent?.Invoke(this, e);
        }

        protected void OnSettingsMenu(EventArgs e)
        {
            SettingsMenuEvent?.Invoke(this, e);
        }

        public MainViewModel()
        {
            ButtonPress = new RelayCommand(IncrementHelloWorldNumber);
            SettingsMenuPress = new RelayCommand(() => OnSettingsMenu(EventArgs.Empty));
            AboutMenuPress = new RelayCommand(() => OnAboutMenu(EventArgs.Empty));
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
