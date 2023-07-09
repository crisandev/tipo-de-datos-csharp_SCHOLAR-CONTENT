namespace TiposDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte edad = 19;
            int millones = 1321932312;
            double pi = 3.1419;
            bool mayorMenor = true;
            char letra = 'a';
            String oracion = "Me llamo Cristian";
            dynamic variable = 12444324;

            Console.WriteLine("El valor de la variable edad es = " + edad);
            Console.WriteLine("El valor de la variable millones es = " + millones);
            Console.WriteLine("El valor de la variable pi es = " + pi);
            Console.WriteLine("El valor de la variable mayorMenor es = " + mayorMenor);
            Console.WriteLine("El valor de la variable letra es = " + letra);
            Console.WriteLine("El valor de la variable oracion es = " + oracion);
            Console.WriteLine("El valor de la variable dynamic es = " + variable);
        }
    }
}