using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MejdunarodniPasporti11d
{
    public class Pasport:Informaciq, IComparable<Pasport>   
    {
        private int izdavane;
        public int Izdavane
        {
            get { return izdavane; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("error");
                }
                this.izdavane = value;
            }
        }
        private int validnost;
        public int Validnost
        {
            get { return validnost; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("error");
                }
                this.validnost = value;
            }
        }
        public Pasport(string name, int egn, int nomer, int izdavane, int validnost):base(name,egn,nomer)
        { 
        this.Izdavane = izdavane;
        this.Validnost = validnost;
        }
        public int CompareTo(Pasport other)
        {
            int result = this.izdavane.CompareTo(other.izdavane);
                if(result==0)
                result=this.validnost.CompareTo(other.Validnost);
            return result;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"{this.izdavane} {this.validnost}");
        }
    }
}
