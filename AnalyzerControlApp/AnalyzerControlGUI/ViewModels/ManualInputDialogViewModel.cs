﻿using AnalyzerControlGUI.Commands;
using AnalyzerDomain;
using AnalyzerDomain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace AnalyzerControlGUI.ViewModels
{
    public class ManualInputDialogViewModel : ViewModel
    {
        private bool? _dialogResult;

        public bool? DialogResult
        {
            get => _dialogResult;
            set {
                _dialogResult = value;
                NotifyPropertyChanged();
            }
        }

        private string _patientDescription;
        public string PatientDescriprion {
            get => _patientDescription;
            set {
                _patientDescription = value;
                NotifyPropertyChanged();
            }
        }

        private ObservableCollection<AnalysisType> _analysisTypes;

        public ObservableCollection<AnalysisType> AnalysisTypes
        {
            get {
                return LoadAnalysisTypesDetails();
            } 
            private set {
                _analysisTypes = value;
                NotifyPropertyChanged("AnalysisTypes");
            }
        }

        private ObservableCollection<AnalysisType> LoadAnalysisTypesDetails()
        {
            using (AnalyzerContext db = new AnalyzerContext())
            {
                db.AnalysisTypes
                    .Include(a => a.Cartridge)
                    .Include(a => a.SamplingStage)
                    .Include(a => a.ConjugateStage)
                    .Include(a => a.EnzymeComplexStage)
                    .Include(a => a.SubstrateStage)
                    .Load();
                return db.AnalysisTypes.Local.ToObservableCollection();
            }
        }

        private int _analysisIndex;

        public int AnalysisIndex
        {
            get { return _analysisIndex; }
            set { _analysisIndex = value; }
        }

        private ObservableCollection<AnalysisType> _sheduledAnalyzes = new ObservableCollection<AnalysisType>();

        public ObservableCollection<AnalysisType> SheduledAnalyzes
        {
            get {
                return _sheduledAnalyzes;
            }
            private set {
                _sheduledAnalyzes = value;
                NotifyPropertyChanged("SheduledAnalyzes");
            }
        }

        private int _sheduledAnalysisIndex;

        public int SheduledAnalysisIndex
        {
            get { return _sheduledAnalysisIndex; }
            set { _sheduledAnalysisIndex = value; }
        }

        #region InputCommand
        RelayCommand _inputCommand;
        public RelayCommand ManualInputCommand {
            get {
                if (_inputCommand == null) {
                    _inputCommand = new RelayCommand(
                       param => input(),
                       param => canInputExecute()
                       );
                }
                return _inputCommand;
            }
        }

        private bool canInputExecute() {
            return true;
        }

        private void input()
        {
            
        }
        #endregion

        #region CancelCommand
        RelayCommand _cancelCommand;
        public RelayCommand CancelCommand
        {
            get
            {
                if (_cancelCommand == null)
                {
                    _cancelCommand = new RelayCommand(
                       param => cancel(),
                       param => true
                       );
                }
                return _cancelCommand;
            }
        }

        private void cancel()
        {
            DialogResult = false;
        }
        #endregion

        #region SheduleAnalysisCommand
        RelayCommand _sheduleAnalysisCommand;
        public RelayCommand SheduleAnalysisCommand {
            get {
                if (_sheduleAnalysisCommand == null) {
                    _sheduleAnalysisCommand = new RelayCommand(
                       param => sheduleAnalysis(),
                       param => AnalysisTypes.Count > 0
                       );
                }
                return _sheduleAnalysisCommand;
            }
        }

        private void sheduleAnalysis()
        {
            AnalysisType analysis = AnalysisTypes[AnalysisIndex];
            if(SheduledAnalyzes.FirstOrDefault(a => a.Id == analysis.Id) == null)
                SheduledAnalyzes.Add(AnalysisTypes[AnalysisIndex]);
        }
        #endregion

        #region UnsheduleAnalysisCommand
        RelayCommand _unsheduleAnalysisCommand;
        public RelayCommand UnsheduleAnalysisCommand
        {
            get
            {
                if (_unsheduleAnalysisCommand == null)
                {
                    _unsheduleAnalysisCommand = new RelayCommand(
                       param => unsheduleAnalysis(),
                       param => SheduledAnalyzes.Count > 0
                       );
                }
                return _unsheduleAnalysisCommand;
            }
        }

        private void unsheduleAnalysis()
        {
            SheduledAnalyzes.RemoveAt(SheduledAnalysisIndex);
        }
        #endregion

        #region UnsheduleAllCommand
        RelayCommand _unsheduleAllCommand;
        public RelayCommand UnsheduleAllCommand
        {
            get
            {
                if (_unsheduleAllCommand == null)
                {
                    _unsheduleAllCommand = new RelayCommand(
                       param => unsheduleAllAnalysis(),
                       param => SheduledAnalyzes.Count > 0
                       );
                }
                return _unsheduleAllCommand;
            }
        }

        private void unsheduleAllAnalysis()
        {
            SheduledAnalyzes.Clear();
        }
        #endregion

        public ManualInputDialogViewModel()
        {

        }
    }
}
