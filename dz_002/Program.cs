Console.WriteLine("Введите первое число ");
double firstNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите второе число ");
double secondNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите третье число ");
double lastNumber = Convert.ToDouble(Console.ReadLine());

double max;

if(firstNumber > secondNumber){
max = firstNumber;
}
else{
max =secondNumber;
}
if(max > lastNumber){
System.Console.WriteLine("max = " + max);}
else{
System.Console.WriteLine("max = " + lastNumber);}
