using System;

namespace ClassLibrary1
{
    public class City
    {
        private string Name;
        protected int Population;

        public string CityName
        {
            get
            {
                return Name;
            }
            set
            {
                if (CheckName(value))
                {
                    Name = value;
                }
            }
        }

        public virtual int CityPopulation
        {
            get => Population;
            set
            {
                if (value >= 0) Population = value;
            }
        }

        private bool CheckName(string? name)
        {
            if (String.IsNullOrWhiteSpace(name)) return false;

            if (name.Length < 3 || name.Length > 20) return false;

            for (int i = 0; i < name.Length; i++)
            {
                if (!char.IsLetter(name[i]))
                    return false;
            }

            return true;
        }
        }
}
