namespace MetodoSimpson13.utils {

    /// <summary>
    /// Clase para el método de Simpson 1/3 para aplicar con n puntos
    /// </summary>
    /// 
    class Simpson13 {
        
        public static double Calcular(Func<double, double> f, double lim_inf, double lim_sup, int n, bool info = false) {

            // n debe de ser par
            if (n % 2 != 0) {
                throw new ArgumentException("El número de intervalos debe ser par.");
            }

            // Calculo de h
            double h = (lim_sup - lim_inf) / n;

            // Variable de la suma de los términos y
            double resultado = 0;

            // Información opcional
            if(info){
                Console.WriteLine($"a (limite inferior) = {lim_inf}");
                Console.WriteLine($"b (limite superior) = {lim_sup}");
                Console.WriteLine($"n (subintervalos) = {n}");
                Console.WriteLine($"h (paso) = (b - a) / n = ({lim_sup} - {lim_inf}) / {n} = {h}");
            }

            // Calculo de la integral
            for(int i = 0; i <= n; i++) {

                // x = limite inferior + (subindice de x * paso)
                double x = lim_inf + i * h;

                if (i == 0 || i == n) { // Primer y último término

                    resultado += f(x);
                    if (info) Console.WriteLine($"f({x}) | extremo | = {f(x)}");

                } else if (i % 2 == 0) { // Términos pares

                    resultado += f(x) * 2;
                    if (info) Console.WriteLine($"f({x}) | impar | = {f(x)} * 2");

                } else {  // Términos impares

                   resultado += f(x) * 4;
                    if (info) Console.WriteLine($"f({x}) | par |= {f(x)} * 4");

                }
            }

            // Resultado final
            resultado = (h / 3) * resultado;
            return resultado;
            
        }
    }
}