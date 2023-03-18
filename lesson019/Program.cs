//

// int Factorial(int n) -интеджер не вывозит количество данных
double Factorial(int n) // - первое число умножает на 10 в степени Е+(число)
{
    // 1! = 1
    // 0! = 1
    if (n == 1) return 1; //return - возврат
    else return n * Factorial(n - 1);

    
}
for(int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
    
    //Console.WriteLine(Factorial(i));
}


