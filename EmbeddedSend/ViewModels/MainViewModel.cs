using System;
using System.Collections.Generic;
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

        public MainViewModel()
        {
            ButtonPress = new RelayCommand(IncrementHelloWorldNumber);
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
