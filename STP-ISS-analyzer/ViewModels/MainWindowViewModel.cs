using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STP_ISS_analyzer.ViewModels.Base;

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
    }
}
