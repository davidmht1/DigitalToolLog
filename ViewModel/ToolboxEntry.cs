using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DigitalToolLog.Models;
using DigitalToolLog.Service;
using System.Collections.ObjectModel;

namespace DigitalToolLog.ViewModel
{
    public partial class ToolboxEntry : ObservableObject
    {
        [ObservableProperty]
        public Toolbox toolbox;

        [ObservableProperty]
        public ToolboxSet setModel;

        bool allBoxes = true;

        public ObservableCollection<string> Message { get; } = new();

        public ToolboxEntry()
        {
            toolbox = new Toolbox();
            setModel = new ToolboxSet(allBoxes);
        }
        [RelayCommand]
        public void SaveToolbox()
        {
            Message.Clear();

            if (Toolbox.Name == string.Empty)
            {
                Message.Add("Enter toolbox name. ");
            }
            if (Toolbox.Identifier == string.Empty)
            {
                Message.Add("Enter toolbox identifier.");
            }

            if (Message.Count == 0)
            {
                try
                {
                    Db.Service().Add(Toolbox);
                    SetModel.ToolboxList.Add(Toolbox);
                    Message.Add($"{Toolbox.Name} added succesfully.");

                    Toolbox = new();

                }
                catch (Exception ex)
                {
                    Message.Add(ex.Message);
                }
            }
        }
        [RelayCommand]
        public void UpdateToolbox()
        {
            Message.Clear();

            if (SetModel.SelectedToolBox.Name == string.Empty)
            {
                Message.Add("Enter toolbox name. ");
            }
            if (SetModel.SelectedToolBox.Identifier == string.Empty)
            {
                Message.Add("Enter toolbox identifier.");
            }

            if (Message.Count == 0)
            {
                try
                {
                    Db.Service().Update(SetModel.SelectedToolBox);
                    Message.Add($"{SetModel.SelectedToolBox.Name} edited succesfully.");

                    Toolbox = new();

                }
                catch (Exception ex)
                {
                    Message.Add(ex.Message);
                }
            }
        }
        [RelayCommand]
        public void DeleteToolbox()
        {
            Message.Clear();

            try
            {
                Db.Service().Delete(SetModel.SelectedToolBox);
                SetModel.ToolboxList.Remove(SetModel.SelectedToolBox);
            }
            catch (Exception ex)
            {
                Message.Add(ex.Message);
            }
        }
    }
}
