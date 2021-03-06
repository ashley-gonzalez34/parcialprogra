using System;

namespace ADIVINAR_EL_NUMERO
{
    class Program
    {
        static void Main(string[] args)
        {
            int numadivinar ;
            int numadivinar2;
            int multi, suma, multi2;
            string cadenanumadinar1;
            string cadenanumadinar2;
            string cadenanumadinar3;
            string cadenanumadinar4;
            int juego;



            Console.WriteLine("\n Bienvenido al juego  \n");
            Console.WriteLine ( "\n JUEGUEMOS !!!\n");
            
            Console.WriteLine(

                          "1. Adivinar el número !!" + "");
            Console.WriteLine(
                          "2. Adivinar el año y tu edad " + "");
                          
            
            
            Console.Write("Eliga un juego ");
            juego = int.Parse(Console.ReadLine());





            switch (juego)  
                
            {
                case 1:


                    Console.WriteLine("Pues te explico , **Debes de tener en mente un numero**,Despues lo que debes de hacer es sumar tu numero con el  2, luego lo multiplicaras con el 8\n");
                    
                    Console.WriteLine("luego lo volveras a multiplicar por el numero 5 ...¿ENTENDISTE?\n ");

                    Console.WriteLine(" ...ESTAS LISTO?? \n");
                    Console.WriteLine( "**INGRESE EL RESULTADO **!! :) ");
                    numadivinar = Convert.ToInt32(Console.ReadLine());
                    numadivinar = numadivinar - 4;

                    multi = numadivinar * 2;
                    suma = multi + 8;
                    multi2 = suma * 5;

                    

                    cadenanumadinar1 = multi2.ToString();
                    cadenanumadinar2 = cadenanumadinar1;
                    int tamCadena = cadenanumadinar2.Length;
                    cadenanumadinar2 = cadenanumadinar2.Substring((tamCadena - 1), 1);

                    cadenanumadinar1 = cadenanumadinar1.Remove(cadenanumadinar1.Length - 1);
                    Console.WriteLine($" Te adivino !! Tu numero es   : {numadivinar}  ");

                    

                    break;
                case 2:

                   


                    Console.WriteLine("Pues te explico , **Debes de tener en mente un numero** despues lo que debes de hacer es multplicarlo con el  numero  20, luego lo sumaras  con el 73\n");
                    Console.WriteLine("luego lo volveras a multiplicar por el numero 5  y por ultimo sumale tu fecha de cumpleaños...¿ENTENDISTE?\n ");

                    Console.WriteLine(" ...ESTAS LISTO?? \n");
                    Console.WriteLine("**INGRESE EL RESULTADO **!! :) ");
                    numadivinar2 = Convert.ToInt32(Console.ReadLine());
                   
                    

                    multi = 20 * numadivinar2;
                    suma = multi + 73;
                    multi2 = suma * 5;
                    numadivinar2 = numadivinar2 - 365;




                    cadenanumadinar3 = multi2.ToString();
                    cadenanumadinar4 = cadenanumadinar3;
                    int tamCadena1 = cadenanumadinar4.Length;
                    cadenanumadinar4 = cadenanumadinar4.Substring((tamCadena1 - 2),1 );

                    cadenanumadinar1 = cadenanumadinar3.Remove(cadenanumadinar3.Length - 2);
                    Console.WriteLine($" Te adivino !! Tu numero es   : {numadivinar2}  ");
                    




                    break;

                 
                

                default:
                    Console.WriteLine("ha elegido la opcion incorrecta :) "); break;



                    

                    

























            }
        }
    }
}
