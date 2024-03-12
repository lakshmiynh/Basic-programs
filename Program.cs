using System;

class Program

{
    static void Main(string[] args)
    {
        Console.WriteLine("hello world");

        // value datatypes

        int i = 10;
        
        float a = 2.2F;

        double b = 444.56;

        char c = 'l';

        short x = 4364;

        long y = 7668276487;

        Console.WriteLine("data types integer=" + i + ",float=" + a + ",double=" + b + ",charector=" + c + ",short=" + x +  ",long="+ y);

        // 1.operatorsss

        // 1.1 Binary operators 

        // 1.1.1 arithemetic operator +,-,*,/,%

        int n = 5, m = 10;

        int result1 = n + m;

        int result2 = n - m;

        int result3 = n * m;

        int result4 = n / m;

        int result5= n % m;

        Console.WriteLine("Addition=" + result1 + "subtrction=" + result2 + "multiplication=" + result3 + "division=" + result4 + "modulodivision=" + result5);

        // relatinal operator >=, <=, < , > , != , ==


        bool r1= n >= m;

        bool r2= n <= m;

        bool r3= n == m;

        bool r4= n > m;

        bool r5= n < m;

        bool r6= n != m;

        Console.WriteLine("n>=m=" + r1 + "n <= m=" + r2 + "n == m=" + r3 + "n < m=" + r4 + "n > m=" + r5 + "n != m=" + r6 );

       // logical operator &&, ||, !

        bool rs1 = (n<m) && (n==m);
        bool rs2 = (n==m) || (n!=m);
        bool rs3 = !(n == m);

        Console.WriteLine("(n<m) && (n==m)=" + rs1 + "(n==m) || (n!=m)=" + rs2 + "!(n == m)=" + rs3);

        // Bitwise operators &, | , <<, >>, ~ , ^


        int v1 = 1001;
        int v2 = 1010;

        int rt1 = v1 & v2;
        int rt2 = v2 | v1;
        int rt3 = v1 ^ v2;
        int rt4 = ~ v2;
        int rt5 = v1>>2;
        int rt6 = v2<<2;

        Console.WriteLine("v1 & v2=" + rt1 + "v1 | v2=" + rt2 + "v1 ^ v2=" + rt3 + "~v2=" + rt4 + "v1>>2=" + rt5 + "v2<<2=" + rt6);


        // Assignment operator =, +=, /=, *=, %= 

        int z = 3;


        int p = 5;

        int rr1= z += p;
        int rr2= z -= p;
        int rr3= z *= p;
        int rr4= z /= p;
        int rr5= z *= p;
        int rr6= z %= p;

        Console.WriteLine("z = 3 = " + z + "z += p = " + rr1 + "z -= p = " + rr2 + "z *= p = " + rr3 + "z %= p");

        // unary operator ++, --

        int rp1 = z++;
        int rp2= z--;
        int rp3= ++z;
        int rp4= --z;

        Console.WriteLine("z++=" + rp1 + "z--=" + rp2 + "++z=" + rp3 + "--z=" + rp4);

        // Ternory operator ?:

        bool ans= (z>p) ? true: false;

        Console.WriteLine(ans); 

        // controle statements 

        // simple if

        if (z>p)
        {
            Console.WriteLine("yes it is true");

        }
       

        // if-else statement 

        if(z>p)
        {
            Console.WriteLine("yes it is true");
        }
        else
        {
            Console.WriteLine("it is false");
        }

        // nested if statemente 

        if (z>p)
        {
            if(z==p)
            {
                Console.WriteLine("both condition is true");
            }

            Console.WriteLine("one condition is true");
        }


        // switch case

        int day = 4;
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
        }

        // for loop 

        for(int i1=0;i1<=10;i1++)
        {
            Console.WriteLine(i1);
        }

        // while loop 

        int n1 = 10;
        while(n1<10)
            {
            Console.WriteLine(n1);
        }

        // do while
        int m1 = 5;

        do
        {
            Console.WriteLine(m1++);
        }while(m1<5);

    }


}
