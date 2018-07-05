using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POC_Specflow.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private string _number1;
        public string Number1
        {
            get { return _number1; }
            set { SetProperty(ref _number1, value); }
        }

        private string _number2;
        public string Number2
        {
            get { return _number2; }
            set { SetProperty(ref _number2, value); }
        }

        private string _result;
        public string Result
        {
            get { return _result; }
            set { SetProperty(ref _result, value); }
        }

        public MainPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            Title = "Main Page";
        }


        private DelegateCommand _addCommand;
        public DelegateCommand AddCommand =>
            _addCommand ?? (_addCommand = new DelegateCommand(ExecuteAddCommand));

        void ExecuteAddCommand()
        {
            Result = (int.Parse(Number1) + int.Parse(Number2)).ToString();
        }
    }
}
