int flag = 0;
int x = 0;
Zombie[] db = null;

while (x!=4)
{
    x = menu(flag);
    if (x == 1)
    {
        flag = 1;
        db = database();
    }
    else if (x == 2)
    {
        Console.WriteLine("Введите год");
        int year = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Выборка по году:");
        for (int i = 0; i < db.Length; i++)
        {
            if (db[i].birth_date == year)
            {
                db[i].Print();
            }
        }
    }
    else if (x == 3)
    {
        for (int i = 0; i < db.Length; i++)
        {
            if (db[i].Type() == 2)
            {
                db[i].Print();
            }
        }
    }

}




static Zombie[] database()
{
    Console.WriteLine("Введите количество элементов в бд");
    int l = Convert.ToInt32(Console.ReadLine());
    Zombie[] db = new Zombie[l];
    for (int i = 0; i<l; i++)
    {
        Console.WriteLine("Укажите тип:\n1) Земледелец\n2) Водитель");
        int chse = Convert.ToInt32(Console.ReadLine());
        if (chse == 1)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите год рождения");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стаж");
            int expirience = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество инструментов которыми владеет");
            int c = Convert.ToInt32(Console.ReadLine());
            string[] tools = new string[c];
            for (int j = 0; j < c; j++)
            {
                Console.WriteLine("Введите название инструмента"); 
                tools[j] = Console.ReadLine();
            }
            db[i] = new Farmer(name, year, expirience, tools);
        }
        else if (chse == 2)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите год рождения");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество авто которыми владеет");
            int c = Convert.ToInt32(Console.ReadLine());
            string[] cars = new string[c];
            for (int j = 0; j < c; j++)
            {
                Console.WriteLine("Введите название авто"); 
                cars[j] = Console.ReadLine();
            }
            db[i] = new Driver(name, year, cars);
        }
    }
    return db;
}

static int menu(int flag)
{
    Console.WriteLine("Меню:\n1) Заполнить бд\n2) Выборка по году рождения \n3) Автомобилисты \n4) Выход");
    int choose = Convert.ToInt32(Console.ReadLine());
    if ((choose == 2 || choose == 3) & flag == 0) {Console.WriteLine("Бд не заполнена!"); return 0;}
    else {return choose;}
}

class Zombie {
    public string name;
    public int birth_date;

    public Zombie(string name, int birth_date)
    {
        this.name = name;
        this.birth_date = birth_date;
    }
    public virtual void Print()
    {
        Console.WriteLine($"Имя: {name} Год: {birth_date}");
    }
    public virtual int Type()
    {
        return 0;
    }
}

class Farmer : Zombie
{
    public int expirience;
    public string[] tools;
    public Farmer(string name, int birth_date, int expirience, string[] tools) : base(name, birth_date)
    {
        this.expirience = expirience;
        this.tools = tools;
    }
    public override void Print()
    {
        Console.WriteLine($"Имя: {name} Год: {birth_date} Опыт: {expirience}");
        Console.WriteLine("Инструменты:");
        for (int i = 0; i < tools.Length; i++)
        {
            Console.WriteLine(tools[i]);
        }
    }

    public override int Type()
    {
        return 1;
    }
}

class Driver : Zombie
{
    public string[] cars;
    public Driver(string name, int birth_date, string[] cars) : base(name, birth_date)
    {
        this.cars = cars;
    }
    public override void Print()
    {
        Console.WriteLine($"Имя: {name} Год: {birth_date}");
        Console.WriteLine("Машины:");
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine(cars[i]);
        }
    }

    public override int Type()
    {
        return 2;
    }
}

