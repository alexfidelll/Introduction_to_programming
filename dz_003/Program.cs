System.Console.WriteLine("Введите число для проверки на четность");
double number = Convert.ToDouble(Console.ReadLine());

double result = number % 2;

if(result == 0){
System.Console.WriteLine("Число четное !");}
else{
System.Console.WriteLine("Число не четное !");}