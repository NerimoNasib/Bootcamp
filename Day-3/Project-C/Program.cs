public static class TempCalculator{
    public static double CelciusToFahrenheit(double temp){
        double celcius = temp;
        double fahrenheit = (celcius * 9/5) + 32;
        return fahrenheit;
    }

    public static double FahrenheitToCelcius(double temp){
        double fahrenheit = temp;
        double celcius = (fahrenheit - 32) * 5/9;
        return celcius;
    }

        public static double CelciusToKelvin(double temp){
        double celcius = temp;
        double kelvin = celcius + 275.15;
        return kelvin;
    }

        public static double KelvinToCelcius(double temp){
        double kelvin = temp;
        double celcius = kelvin - 275.15;
        return celcius;
    }
}



class TemperatureCalculator{
    static void Main(){
        Console.WriteLine(TempCalculator.FahrenheitToCelcius(78.0));
        Console.WriteLine(TempCalculator.CelciusToFahrenheit(33.0));
        System.Console.WriteLine(TempCalculator.CelciusToKelvin(39.0));
        System.Console.WriteLine(TempCalculator.KelvinToCelcius(400.0));
    }
}