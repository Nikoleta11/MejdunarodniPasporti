using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MejdunarodniPasporti11d
{
    public class Informaciq:IPrint
    {
        private string name;
        public string Name 
        { 
            get { return name; } 
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("error");
                }
                this.name = value; 
            }
        }
        private int egn;
        public int Egn
        {
            get { return egn; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("error");
                }
                this.egn = value;
            }
        }
        private int nomer;
        public int Nomer
        {
            get { return nomer; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("error");
                }
                this.nomer = value;
            }
        }
        public Informaciq(string name,int egn,int nomer)
        {
            this.Name = name;
            this.Egn = egn;
            this.Nomer = nomer;
        }
        public virtual void Print() 
        {
            Console.WriteLine($"{this.name}{this.egn}{this.nomer}");
        }
    }
}
