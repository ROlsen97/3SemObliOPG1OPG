namespace _3SemObliOPG1OPG
{
    using System.Reflection;
        public class Car
        {
            public int Id { get; set; }
            public string? Model { get; set; }
            public int Price { get; set; }
            public string? Licenseplate { get; set; }

            public override string ToString()
            {
                return Id + " " + Model + " " + Price + " " + Licenseplate;
            }

            public void ModelValidering()
            {
                if (Model?.Length <= 4)
                    throw new ArgumentException($"Model: {Model} længden er mindre end 4, tilføj flere tegn");
            }
            public void PriceValidering()
            {
                if (Price <= 0)
                    throw new ArgumentOutOfRangeException($"Prisen: {Price} er mindre end eller det samme som nul, den skal være højere");
            }
            public void LicensePlateValidering()
            {
                if (Licenseplate?.Length <= 2)
                    throw new ArgumentException($"Nummerpladen : {Licenseplate} har mindre end 2 tegn");

                if (Licenseplate?.Length >= 7)
                    throw new ArgumentException($"Nummerpladen : {Licenseplate} har flere end 7 tegn");
            }
            public void Validate()
            {
                ModelValidering();
                PriceValidering();
                LicensePlateValidering();
            }
        }
    }