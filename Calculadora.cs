namespace misClases // Es un agrupador logico de clases
{
    public class Calculadora
    {
        private double dato;

        public Calculadora(double valorInicial)
        {
            dato = valorInicial;
        }

        public void Sumar(double termino)
        {
            dato += termino;
        }

        public void Restar(double termino)
        {
            dato -= termino;
        }

        public void Multiplicar(double termino)
        {
            dato *= termino;
        }
        public void Dividir(double termino)
        {
            if(termino != 0)
            {
                dato /= termino;
            }else{
                throw new DivideByZeroException("No se puede dividir por cero.");
            }
        }
        public void Limpiar(){
            dato = 0;
        }

        public double Resultado{
            get => dato; //Sirve para mostrar, pero no para escribir o modificar, para eso esta el set
        }
    }

    // Definición de la enumeración para los cargos
    public enum Cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }


    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public char EstadoCivil { get; set; }
        public DateTime FechaIngreso { get; set; }
        public double SueldoBasico { get; set; }
        public string Cargo { get; set; }

        public int Antiguedad
        {
            get
            {
                return DateTime.Now.Year - FechaIngreso.Year;
            }
        }

        public int Edad
        {
            get
            {
                return DateTime.Now.Year - FechaNacimiento.Year;
            }
        }

        public int AniosParaJubilacion
        {
            get
            {
                return 65 - Edad;
            }
        }

        public double CalcularSalario()
        {
            double adicional = 0;
            int antiguedad = this.Antiguedad;

            // Calcula el adicional por antigüedad
            if (antiguedad <= 20)
            {
                adicional = SueldoBasico * 0.01 * antiguedad;
            }
            else
            {
                adicional = SueldoBasico * 0.25;
            }

            // Incremento por cargo
            if (Cargo == "Ingeniero" || Cargo == "Especialista")
            {
                adicional *= 1.5;
            }

            // Incremento por estar casado
            if (EstadoCivil == 'C')
            {
                adicional += 150000;
            }

            return SueldoBasico + adicional;
        }
    }   
}
