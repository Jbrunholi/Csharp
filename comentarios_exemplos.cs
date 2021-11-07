// EXEMPLO DE COMENTÁRIO QUE EXPLICA O CÓDIGO SENDO OBJETIVO

/*
  O código a seguir cria cinco OrderIds de modo Random
  para testar o processo de detecção de fraude. OrderIDs 
  consistem de letras de A até E, e três
  dígitos de números. Ex. A123.
*/

Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}