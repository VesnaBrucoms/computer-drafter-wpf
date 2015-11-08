using Computer_Drafter.Models;
using Computer_Drafter.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Computer_Drafter.ViewModels
{
    class GpuViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<GpuModel> gpuModules;

        #region ModelProperties
        public ObservableCollection<GpuModel> GetGpuModules
        {
            get { return gpuModules; }
        }
        #endregion

        #region CommandProperties
        public ICommand AddGpuCommand
        {
            get { return new DelegateCommand(AddGpu, CanAddGpu); }
        }

        public ICommand RemoveGpuCommand
        {
            get { return new DelegateCommand(RemoveGpu, CanRemoveGpu); }
        }
        #endregion

        public GpuViewModel(MainWindowViewModel parent)
        {
            parent.DraftOpened += new MainWindowViewModel.NewDraftEventHandler(newComputerDraftUpdateProperties);

            gpuModules = parent.GetComputer.GetGpus;
        }

        private void newComputerDraftUpdateProperties()
        {
            //
        }

        #region Commands
        private void AddGpu(object parameter)
        {
            gpuModules.Add(new GpuModel());
            gpuModules[gpuModules.Count - 1].PartNumber = gpuModules.Count;
        }

        private bool CanAddGpu()
        {
            return true;
        }

        private void RemoveGpu(object parameter)
        {
            GpuModel model = (GpuModel)parameter;
            gpuModules.Remove(model);

            int count = 0;
            foreach (GpuModel module in gpuModules)
            {
                if (module.PartNumber - 1 != count)
                    module.PartNumber = count + 1;

                count++;
            }
        }

        private bool CanRemoveGpu()
        {
            return true;
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
                Console.WriteLine(propertyName);
            }
        }
    }
}
