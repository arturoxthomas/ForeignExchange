﻿


namespace ForeignExchange.ViewModels
{

    using System.Collections.ObjectModel;
    using Models;
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;
    using System;

    class MainViewModel
    {

        #region Properties
        public string Amount { get; set; }

        public ObservableCollection <Rate> Rates { get; set; }

        public Rate SourseRate { get; set; }

        public Rate TargetRate { get; set; }

        public bool IsRunning { get; set; }

        public bool IsEnabled { get; set; }

        public string Result { get; set; }


        #endregion
        public MainViewModel()
        {

        }

        #region Commands
        public ICommand ConvertCommand
        {
            get
            {
                return new RelayCommand(Convert);
            }

         }

        void Convert()
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
