using HouseApp;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

public class ResultsViewModel : BaseViewModel
{
    public ObservableCollection<HouseModel> Houses { get; }
    public ICommand ReturnToSearchCommand { get; }

    public ResultsViewModel(List<HouseModel> houses)
    {
        Houses = new ObservableCollection<HouseModel>(houses);
        ReturnToSearchCommand = new RelayCommand(ReturnToSearch);
    }

    private void ReturnToSearch()
    {
        Application.Current.Dispatcher.Invoke(() =>
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        });

        // Закрываем текущее окно
        Application.Current.Windows[Application.Current.Windows.Count - 1].Close();
    }
}
