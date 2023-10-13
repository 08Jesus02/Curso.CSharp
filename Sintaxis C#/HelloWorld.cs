using System;

namespace CSharpHelloWorl
{
    class HelloWorld
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, C#");
            string myString = "Esto es una cadena de texto";
            myString = "Aqui cambio el valor de la cadena de texto";
            Console.WriteLine(myString);

            int myInt = 7;
            myInt = myInt + 4;
            Console.WriteLine(myInt);
            Console.WriteLine(myInt - 1);
            Console.WriteLine(myInt);

            double myDoble = 6.5;
            Console.WriteLine(myDoble);

            float myFloat = 6.5f;
            Console.WriteLine(myFloat);

            Console.WriteLine(myInt + myFloat + myDoble);

            bool myBool = true;
            myBool = false;
            Console.WriteLine(myBool);

            dynamic myDynamic = 6;
            myDynamic = "Mi dato dinamico";
            Console.WriteLine(myDynamic);
            Console.WriteLine(myDynamic + myFloat);

            var myVar = "Mi nueva cadena de texto";
            // myVar = 6; Error
            myVar = "Actializacion de mi cadena te texto";
            Console.WriteLine(myVar);



            Console.WriteLine($"El valores de mi entero es {myInt} y el de mi bool {myBool}");

            const string myConst = "Mi Constante";
            Console.WriteLine(myConst);

            //Arrays

            var myArray = new string[] { "Angel", "Soriano", "Garcia" };
            Console.WriteLine(myArray[2]);

            myArray[2] = "18";
            Console.WriteLine(myArray[2]);

            var myDictionary = new Dictionary<string, int>
            {
                {"Angel", 18},
                {"Frangel", 15},
                {"Provo", 17}
            };
            Console.WriteLine(myDictionary["Provo"]);

            var mySet = new HashSet<string> { "Angel", "Soriano", "Garcia" };

            var myTuple = ("Angel", "Soriano", "Garcia");
            //Console.WriteLine(myTuple[0]); Error
            Console.WriteLine(myTuple);

            //Blucles

            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine(index);
            }


            foreach (var myItem in myArray)
            {
                Console.WriteLine(myItem);
            }

            foreach (var myItem in myDictionary)
            {
                Console.WriteLine(myItem);
            }

            foreach (var myItem in mySet)
            {
                Console.WriteLine(myItem);
            }


            //Flujos
            myInt = 11;
            myBool = true;

            if (myInt == 11 && myBool == true)
            {
                Console.WriteLine("El valor es 11");
            }

            else if (myInt == 12 || myBool == false)
            {
                Console.WriteLine("El valor es 12");
            }

            else
            {
                Console.WriteLine("El valor es no es 11 ni 12");
            }


            //Funciones
            myFunction();
            Console.WriteLine(myFunctionwthReturn(4));

            //Clases
            var myClass = new MyClass("Angel");
            myClass.myName = "Angel";
            Console.WriteLine(myClass.myName);
        }

        static void myFunction()
        {
            Console.WriteLine("Mi funcion");
        }
        static int myFunctionwthReturn(int param)
        {
            return 10 + param;
        }

        class MyClass
        {
            public string myName { get; set; }

            public MyClass(string myName)
            {
                this.myName = myName;
            }

        }

    }

}

