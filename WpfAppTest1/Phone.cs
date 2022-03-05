using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using WpfAppTest1.Annotations;

namespace WpfAppTest1;
public class Phone : INotifyPropertyChanged
{
    private string name;
    public string Name
    {
        get { return name;}
        set
        {
            name = value;
            OnPropertyChanged(nameof(Name));
        }
    }

    public void Type()
    {
        Debug.Write(String.Format("{0}klkl", name));
    }
    public int Price { get; set; }
      
    public override string ToString()
    {
        return $"Смартфон {this.Name}; цена: {this.Price}";
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    [NotifyPropertyChangedInvocator]
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}