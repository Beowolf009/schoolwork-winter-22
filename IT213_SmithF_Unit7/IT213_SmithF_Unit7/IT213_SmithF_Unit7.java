package IT213_SmithF_Unit7;
import java.util.*;
import java.io.*;

public class IT213_SmithF_Unit7{
  
    

public static void main(String[] args) {
    //Scanner temperatureInput = new Scanner(System.in);
    double temp1 = 35.5;
    double temp2 = 30.5;
    double temp3 = 22.2;
    double temp4 = 16.1;
    double temp5 = 7.3;
    double temp6 = -1;
    int tempF = 0;
    String advisory = " ";

    tempF = tempConversion(temp1);
    advisory = WeatherStatement(tempF);
    System.out.println("The temperature is " + temp1 + "C or " + tempF + "F. " + advisory + "\n");

    tempF = tempConversion(temp2);
    advisory = WeatherStatement(tempF);
    System.out.println("The temperature is " + temp2 + "C or " + tempF + "F. " + advisory + "\n");

    tempF = tempConversion(temp3);
    advisory = WeatherStatement(tempF);
    System.out.println("The temperature is " + temp3 + "C or " + tempF + "F. " + advisory + "\n");

    tempF = tempConversion(temp4);
    advisory = WeatherStatement(tempF);
    System.out.println("The temperature is " + temp4 + "C or " + tempF + "F. " + advisory + "\n");

    tempF = tempConversion(temp5);
    advisory = WeatherStatement(tempF);
    System.out.println("The temperature is " + temp5 + "C or " + tempF + "F. " + advisory + "\n");

    tempF = tempConversion(temp6);
    advisory = WeatherStatement(tempF);
    System.out.println("The temperature is " + temp6 + "C or " + tempF + "F. " + advisory + "\n");
  }

  public static int tempConversion(double tempC){
       int intTemp = (int)Math.round(tempC * 9.0 / 5.0 + 32);
            return intTemp;
  }
  public static String WeatherStatement(int tempF){
    if(tempF >= 95 ){
       return "A heat advisory has been issued. "; 
    }
    if(tempF >= 85){
        return "Pleasant, but warm.";
    }
    if(tempF >= 70){
        return "Very pleasant day today.";
    }
    if(tempF >= 50){
        return "Best weather.";
    }
    if(tempF >= 33){
        return "Cold weather";
    }
    else{
        return "A freeze warning has been issued";
    }

    
}
}