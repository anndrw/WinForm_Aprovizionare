using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    internal class Contract : ICloneable, IComparable
    {
        private int codContract;
        private DateTime dataIncheiere;
        private DateTime dataExpirare;
        private Furnizor furnizor;
        public Contract()
        {
            codContract = 0;
            dataIncheiere = DateTime.Now;
            dataExpirare = DateTime.Now;
            furnizor = new Furnizor();
        }
        public Contract(int codContract, DateTime dataIncheiere, DateTime dataExpirare, Furnizor furnizor)
        {
            this.codContract = codContract;
            if (dataIncheiere > dataExpirare)
            {
                throw new Exception("Data de incheiere a contractului este mai mare decat data de expirare!");
            }
            this.dataIncheiere = dataIncheiere;
            this.dataExpirare = dataExpirare;
            this.furnizor = furnizor;
        }
        
        public int CodContract
        {
            get { return codContract; }
            set { codContract = value; }
        }
        public DateTime DataIncheiere
        {
            get { return dataIncheiere; }
            set { dataIncheiere = value; }
        }
        public DateTime DataExpirare
        {
            get { return dataExpirare; }
            set { dataExpirare = value; }
        }
        public Furnizor Furnizor
        {
            get { return furnizor; }
            set { furnizor = value; }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            Contract c = (Contract)obj;
            if (this.codContract < c.codContract)
            {
                return -1;
            }
            else if (this.codContract > c.codContract)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
