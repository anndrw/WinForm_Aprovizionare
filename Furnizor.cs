using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    internal class Furnizor
    {
        private string nume;
        private int codFurnizor;
        private DateTime dataInregistrare;
        private Produs[] listaProduse; // vector alocat dinamic
        public Furnizor()
        {
            nume = "Anonim";
            codFurnizor = 0;
            dataInregistrare = DateTime.Now;
            listaProduse = new Produs[0]; 
        }
        public Furnizor(string nume, int codFurnizor, DateTime dataInregistrare, Produs[] listaProduse)
        {
            this.nume = nume;
            this.codFurnizor = codFurnizor;
            this.dataInregistrare = dataInregistrare;

            if(listaProduse != null || listaProduse.Length == 0) // validare
            {
                throw new Exception ("Lista de produse este goala!");
            }
            
            this.listaProduse = listaProduse;
        }
        ~Furnizor()
        {
            listaProduse = null;
        }
        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        public int CodFurnizor
        {
            get { return codFurnizor; }
            set { codFurnizor = value; }
        }
        public DateTime DataInregistrare
        {
            get { return dataInregistrare; }
            set { dataInregistrare = value; }
        }
        public Produs[] ListaProduse
        {
            get { return listaProduse; }
            set { listaProduse = value; }
        }
    }
}
