Console.Clear();
//Console.SetCursorPosition(10,4);
//Console.WriteLine("+");

int xa= 40, ya = 1,
    xb=1, yb = 30,
    xc=80, yc=30;

    Console.SetCursorPosition(xa,ya);
    Console.WriteLine("+");

    Console.SetCursorPosition(xb,yb);
    Console.WriteLine("+");

    Console.SetCursorPosition(xc,yc);
    Console.WriteLine("+");
    //Выберем случайную точку
    int x=xa, y=xb;
    //Сделаем счетчик
    int count=0;

    while (count<10000)
    {
        int what = new Random().Next(0,3);//Задаем случайные числа в интервале [0 до 3] это 0, 1 или 2

        if (what==0)
        {
            x=(x+xa)/2;
            y=(y+ya)/2;
        }
        if (what==1)
        {
            x=(x+xb)/2;
            y=(y+yb)/2;
        }
        if (what==2)
        {
            x=(x+xc)/2;
            y=(y+yc)/2;
        }
        //Рисуем вершину
        Console.SetCursorPosition(x,y);
        Console.WriteLine("+");

        count=count+1;
    }