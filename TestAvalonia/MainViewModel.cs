using System.Collections.ObjectModel;

namespace TestAvalonia;

public class MainViewModel
{
    public ObservableCollection<int> ListTest { get; } = new();

    public MainViewModel()
    {
        for (var i = 0; i < 100; i++)
        {
            ListTest.Add(i);
        }

    }

    public void RemoveFirstCommand()
    {
        ListTest.RemoveAt(0);
    }
}