using System;

namespace Easy;

public class RomanNumeralReduction
{
    static String RomanNumeralReduction(String str){
        return reduce(calculate(str));
    }
    static String reduce(int num) { // 800 = DCCC, 899 = DCCCXCIX, 900 = CM, 999 = CMXCIX
        String mResult = "";
        int[] values = {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
        String[] letters = {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};
        int i = 0;
        while (num > 0) {
            while (num >= values[i]) {
                mResult += letters[i];
                num -= values[i];
            }
            i++;
        }
        return mResult;
    }
    //==================
    static int calculate(String roman){
        // DCCCXCIX(899) => DCCC-XC-IX => DCCC(800=500+100+100+100) + XC(90=-10+100) + IX(9=-1+10)
        // Eğer karakter değeri, sonrakinden küçükse değeri toplamdan çıkar
        // Değilse toplama ekle
        int sum = 0;
        for (int i = 0; i < roman.Length; i++) {
            if (i + 1 < roman.Length && value(roman[i]) < value(roman[i + 1]))
                sum -= value(roman[i]);
            else
                sum += value(roman[i]);
        }
        return sum;
    }
    //==================
    static int value(char c){
        switch (c){
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
            default: return 0;
        }
    }
    static void Main(){
        Console.WriteLine(RomanNumeralReduction(Console.ReadLine())); 
    }
}