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
        private string nombre;
        private string apellido;
        private DateTime fechaDeNacimiento;
        private char estadoCivil;
        private DateTime fechaIngreso;
        private double sueldoBasico;
        private Cargos cargoEmpleado;
    }
}