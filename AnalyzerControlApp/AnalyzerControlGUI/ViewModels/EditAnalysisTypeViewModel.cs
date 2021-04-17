﻿using AnalyzerControlGUI.Commands;
using AnalyzerDomain;
using AnalyzerDomain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyzerControlGUI.ViewModels
{
    public class EditAnalysisTypeViewModel : ViewModel
    {
        private string _cartridgeBarcode;

        public string CartridgeBarcode
        {
            get { return _cartridgeBarcode; }
            set { 
                _cartridgeBarcode = value;
                NotifyPropertyChanged("CartridgeBarcode");
            }
        }

        private List<Cartridge> _cartridges;

        public List<Cartridge> Cartridges
        {
            get { return LoadCartridgesDetails(); }
            set
            {
                _cartridges = value;
                NotifyPropertyChanged("Cartridges");
            }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { 
                _description = value;
                NotifyPropertyChanged("Description");
            }
        }

        private List<Cartridge> LoadCartridgesDetails()
        {
            using (AnalyzerContext db = new AnalyzerContext())
            {
                db.Cartridges.Load();
                return db.Cartridges.Local.ToList();
            }
        }

        private bool? _dialogResult;

        public bool? DialogResult
        {
            get => _dialogResult;
            set
            {
                _dialogResult = value;
                NotifyPropertyChanged();
            }
        }

        RelayCommand _okCommand;

        public RelayCommand OkCommand
        {
            get
            {
                if (_okCommand == null)
                {
                    _okCommand = new RelayCommand(
                       param => { DialogResult = true; },
                       param => true);
                }
                return _okCommand;
            }
        }

        RelayCommand _cancelCommand;

        public RelayCommand CancelCommand
        {
            get
            {
                if (_cancelCommand == null)
                {
                    _cancelCommand = new RelayCommand(
                       param => { DialogResult = false; },
                       param => true);
                }
                return _cancelCommand;
            }
        }
    }
}
