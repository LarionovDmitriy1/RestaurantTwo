using Restaurant1;

void Menu()
{
    List<string> list = new List<string>()
        {
            "Burger","Fries","Chicken","Pizza","Sandwich","Onionrings","Milkshake","Coke"
        };
    Console.WriteLine();
    Console.WriteLine("Меню ресторана");
    Console.WriteLine();
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine();
    Console.WriteLine("Ваш заказ");
}
void SelectedMenuItem()
{
    List<string> list = new List<string>()
    {
        "Burger","Fries","Chicken","Pizza","Sandwich","Onionrings","Milkshake","Coke"
    };
    string menu = Console.ReadLine();
    MenuParser.Parser(menu, list);

}
while (true)
{
    Menu();
    SelectedMenuItem();
}