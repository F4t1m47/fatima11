namespace examen_1
{
    public static class program
    {
        public static void Main()
        {
            float salario;
            Console.WriteLine("ingrese su salario");
            salario = float.Parse(Console.ReadLine());
            if (salario > 2000)
            {
                Console.WriteLine(" su nuevo salario es: " + salario * 10);
            }
            else 
            
            {
                Console.WriteLine("su nuevo salario es: " + salario * 5);
            }
            Console.ReadKey();
                
        }
    }
}
