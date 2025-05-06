namespace MetodoSimpson13.utils;

class Ecuaciones {

    public static double EqUno(double x) { // x^2 + 2x + 1
        return Math.Pow(x, 2) + 2 * x + 1;
    }

    public static double EqDos(double x) { // x^3 + 2x^2 + 3x + 4
        return Math.Pow(x, 3) + 2 * Math.Pow(x, 2) + 3 * x + 4;
    }

    public static double EqTres(double x) { // x^4 + 2x^3 + 3x^2 + 4x + 5
        return Math.Pow(x, 4) + 2 * Math.Pow(x, 3) + 3 * Math.Pow(x, 2) + 4 * x + 5;
    }
}

