using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using STP_ISS_analyzer.Infrastructure.Commands;
using STP_ISS_analyzer.ViewModels.Base;
using System.Windows;

namespace STP_ISS_analyzer.ViewModels
{
    class MainWindowViewModel : ViewModel
    {
        private string _Title = "STP-ISS-Analyzer";

        /// <summary>Заголовок Окна</summary>
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }

        private string _Status = "Готов";

        /// <summary>Статус программы</summary>
        public string Status
        {
            get => _Status;
            set => Set(ref _Status, value);
        }

        #region Commands

        #region CloseAppCommand

        public ICommand CloseAppCommand { get; }
        
        private void OnCloseAppCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }

        private bool CanCloseAppCommandExecuted(object p) => true;

        #endregion

        #endregion

        public MainWindowViewModel()
        {
            CloseAppCommand = new RelayCommand(OnCloseAppCommandExecuted, CanCloseAppCommandExecuted);
        }
    }
}

