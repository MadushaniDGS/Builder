using Builder;

namespace designPatterns
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Computer c1 = new Computer.ComputerBuilder().
            Cpu("I7").Ram("4GB").Storage("1TB").Build();
            c1.Display();

            Computer c2 = new Computer.ComputerBuilder().
            Cpu("I3").Ram("3GB").Storage("16GB").Build();
            c2.Display();

        }
    }
}