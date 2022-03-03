namespace WpfAppTest1;

public class Phone
{
    public string Name { get; set; }
    public int Price { get; set; }
      
    public override string ToString()
    {
        return $"Смартфон {this.Name}; цена: {this.Price}";
    }
}