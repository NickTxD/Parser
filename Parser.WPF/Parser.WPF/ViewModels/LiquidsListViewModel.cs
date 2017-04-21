using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ExampleSolution.WPF.Commands;
using Parser.WPF.Annotations;
using Parser.WPF.DataAccess;
using Parser.WPF.DataAccess.Interfaces;
using Parser.WPF.Models;

namespace Parser.WPF.ViewModels
{
    public class LiquidsListViewModel : INotifyPropertyChanged
    {
        private readonly IDataAccess<Liquid> liquidDataAccess;

        private ObservableCollection<Liquid> _liquids;

        public RelayCommand<Liquid> UpdateLiquidListCommand { get; }

        public ObservableCollection<Liquid> Liquids
        {
            get { return this._liquids; }
            set
            {
                this._liquids = value;
                this.OnPropertyChanged();
            }
        }

        public LiquidsListViewModel()
        {
            this.liquidDataAccess = new LiquidsDataAccess();
          //  GetLiquids(null);
            this.UpdateLiquidListCommand = new RelayCommand<Liquid>(null, this.GetLiquids);
           
        }

        private void GetLiquids(Liquid obj)
        {
            this.Liquids = new ObservableCollection<Liquid>(this.liquidDataAccess.Get());
            this.OnPropertyChanged();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}