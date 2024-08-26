using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
        public class Computer
        {

            private string cpu { get; set; }
            private string ram { get; set; }
            private string storage { get; set; }

            Computer(ComputerBuilder computerBuilder)
            {
                this.cpu = computerBuilder.cpu;
                this.ram = computerBuilder.ram;
                this.storage = computerBuilder.storage;
            }

            public void Display()
            {
                Console.WriteLine($"{cpu} {ram} {storage}");
            }

            public class ComputerBuilder
            {

                public string cpu { get; set; }
                public string ram { get; set; }
                public string storage { get; set; }

                public ComputerBuilder Cpu(string cpu)
                {
                    this.cpu = cpu;
                    return this;
                }

                public ComputerBuilder Ram(String ram)
                {
                    this.ram = ram;
                    return this;
                }

                public ComputerBuilder Storage(string storage)
                {
                    this.storage = storage;
                    return this;
                }

                public Computer Build()
                {
                    return new Computer(this);
                }

            }

        }
    

}
