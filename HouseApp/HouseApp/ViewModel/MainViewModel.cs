using HouseApp;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

public class MainViewModel : BaseViewModel
{
    private string _address;
    private string _city;
    private readonly ApiService _apiService;

    public string Address
    {
        get => _address;
        set { _address = value; OnPropertyChanged(); }
    }

    public string City
    {
        get => _city;
        set { _city = value; OnPropertyChanged(); }
    }

    public ICommand SearchCommand { get; }

    public MainViewModel()
    {
        _apiService = new ApiService();
        SearchCommand = new RelayCommand(async () => await SearchHouses());
    }

    private async Task SearchHouses()
    {
        var houses = await _apiService.GetHousesAsync(Address, City);

        Application.Current.Dispatcher.Invoke(() =>
        {
            ResultsWindow resultsWindow = new ResultsWindow(houses);
            resultsWindow.Show();
        });
    }
}
