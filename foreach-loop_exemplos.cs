// Exemplo de loop para somar os valores de uma matriz

int[] inventory = { 100, 250, 450, 275, 150 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} itens (Running total: {sum})");
}
Console.WriteLine($"Nós possuímos {sum} itens no inventário.");

// Armazenar e iterar em sequência de dados usando Matrizes e instrução foreach

string [] OrderIDs = { "B123" , "C234" , "A345" , "C15" , "B177" , "G3003" , "C235" , "B179" };

foreach (string orderID in OrderIDs)
{
    if(orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}