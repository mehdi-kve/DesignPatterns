 namespace Observer;

class Program
{
    static void Main(string[] args)
    {
        var data = new DataSource();
        var sheet1 = new SpreadSheet();
        var sheet2 = new SpreadSheet();
        var chart = new Chart();  
        
        data.addObserver(sheet1);
        data.addObserver(sheet2);
        data.addObserver(chart);

        data.setValue(1);
    }
}
