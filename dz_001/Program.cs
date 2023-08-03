Console.WriteLine("Введите первое число ");
double firstNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите второе число ");
double lastNumber = Convert.ToDouble(Console.ReadLine());

if(firstNumber > lastNumber) Console.WriteLine($"Max = {firstNumber}" + $"| Min = {lastNumber}");
    
else Console.WriteLine($"Max = {lastNumber}" + $"Min = {firstNumber}");

    

