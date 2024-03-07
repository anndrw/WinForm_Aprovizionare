using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    internal class Material : ICloneable, IComparable
    {
        private int codMaterial;
        private string nume;
        private string tip;
        private float pret;
        private int stoc;
        public Material()
        {
            codMaterial = 0;
            nume = "Anonim";
            tip = "Anonim";
            pret = 0;
            stoc = 0;
        }
        public Material(int codMaterial, string nume, string tip, float pret, int stoc)
        {
            this.codMaterial = codMaterial;
            this.nume = nume;
            this.tip = tip;
            if (pret < 0)
            {
                throw new Exception("Pretul nu poate fi negativ!");
            }
            else
            {
                this.pret = pret;
            }
            if (stoc < 0)
            {
                throw new Exception("Stocul nu poate fi negativ!");
            }
            else
            {
                this.stoc = stoc;
            }
        }
        public int CodMaterial
        {
            get { return codMaterial; }
            set { codMaterial = value; }
        }
        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        public string Tip
        {
            get { return tip; }
            set { tip = value; }
        }
        public float Pret
        {
            get { return pret; }
            set { pret = value; }
        }
        public int Stoc
        {
            get { return stoc; }
            set { stoc = value; }
        }

        public class MaterialException : Exception
        {
            public MaterialException(string message) : base(message)
            {
                Console.WriteLine("MaterialException: " + message);
            }
        }

        public object Clone()
        {
            try
            {
            return this.MemberwiseClone();
            }
            catch (Exception e)
            {
                throw new MaterialException("Eroare la clonare material: " + e.Message);
            }
        }

        public int CompareTo(object obj)
        {
            Material m = (Material)obj;
            if (this.pret < m.pret)
            {
                return -1;
            }
            else if (this.pret > m.pret)
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
