class Elma
{
    decimal _agirlik;
    decimal _hacim;
    public void SetAgirlik(decimal agirlik)
    {
        if (agirlik > 100 && agirlik < 500)
        {
            _agirlik = agirlik;
        }
        else
        {
            Console.WriteLine("Ağırlık değeri 100 - 500 aralığında olmalıdır");
        }
    }
    public decimal GetAgirlik()
    {
        return _agirlik;
    }
    public void SetHacim(decimal hacim)
    {
        if (hacim > 5 && hacim < 20)
        {
            _hacim = hacim;
        }
        else
        {
            Console.WriteLine("Hacim değeri 5 - 20 aralığında olmalıdır");
        }
    }
    public void GetHacim(string sifre)
    {
        if (sifre == "1234")
        {
            Console.WriteLine("Hacim: " + _hacim.ToString());
        }
        Console.WriteLine("Bu veriyi görme yetkiniz yok");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Elma elma = new Elma();
        elma.SetAgirlik(770);
        elma.GetAgirlik();
        elma.SetHacim(30);
        elma.SetAgirlik(220);
        elma.SetHacim(10);
        Console.WriteLine("Ağırlık : " + elma.GetAgirlik());
        elma.GetHacim("4523");
        elma.GetHacim("1234");
        Console.ReadKey();
    }
}
class Person
{
    private string _name;
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    #endregion
    #region 2. Yöntem
    private string _surname;
    public string Surname
    {
        get { return _surname; }
        set { _surname = value; }
    }
    #endregion
    public string EMail { get; set; } 
    #endregion
}

static void Main(string[] args)
{
    Person person = new Person();
    person.SetName("Marty");
    person.Surname = "McFly";
    person.EMail = "marty@mcfly.com";
    Console.WriteLine("İsim: " + person.GetName());
    Console.WriteLine("Soyisim: " + person.Surname);
    Console.WriteLine("E-Mail: " + person.EMail);
    Console.ReadKey();
}

