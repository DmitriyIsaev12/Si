Console.WriteLine("ВВЕДИТЕ ИМЯ");
string username = Console.ReadLine();
if(username.ToLower() == "маша") //Чтобы имя Маша распознавалоось не зависимо от того как его ввел пользователь, надо вызвать операцию  ToLower()
// Эта функция переведет все символы строки в нижний регистр
{
    Console.WriteLine("Ура!");

}
else
{
    Console.Write("Привет,    ");
    Console.WriteLine(username);
}

