using System;

namespace Ejercicios_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.Hacer un programa que solicite el ingreso de dos números y luego calcular
            //La resta si el primero es mayor que el segundo.
            //La suma si son iguales.
            //El producto si el primero es menor.
            //Se deberá emitir un cartel por pantalla con el resultado correspondiente.
            Console.WriteLine("1.Hacer un programa que solicite el ingreso de dos números y luego calcular");
            Console.WriteLine("La resta si el primero es mayor que el segundo.");
            Console.WriteLine("La suma si son iguales");
            Console.WriteLine("El producto si el primero es menor");
            Console.WriteLine("Se deberá emitir un cartel por pantalla con el resultado correspondiente");



            int n1, n2, resultado;

            Console.WriteLine("Ingresar un numero : ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar otro numero : ");
            n2= int.Parse(Console.ReadLine());

                if (n1 > n2)
                {
                    resultado = n1 - n2;

                }
                else if (n1 == n2)

                    resultado = n1 + n2;

                else
                    resultado = n1 * n2;

            Console.WriteLine("El resultado es : " + resultado);


            //2.Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala: 
            //Si vende menos de 100 litros, no hay descuento.
            //Si vende entre 101 y 300 litros, el descuento es del 10 %.
            //Si vende entre 301 y 500 litros, el descuento es del 15 %.
            //Finalmente, si la venta es de más de 500 litros, el descuento es del 25 %.
            //Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad
            //de litros vendidos y calcule y emita el importe con el descuento  aplicado.. 

            Console.WriteLine("2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala");
            Console.WriteLine("Si vende menos de 100 litros, no hay descuento.");
            Console.WriteLine("Si vende entre 101 y 300 litros, el descuento es del 10 %");
            Console.WriteLine("Si vende entre 301 y 500 litros, el descuento es del 15 %");
            Console.WriteLine("Finalmente, si la venta es de más de 500 litros, el descuento es del 25 %");
            Console.WriteLine("Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad");
            Console.WriteLine("de litros vendidos y calcule y emita el importe con el descuento  aplicado..");


            int importedeLitro, litros;
            float precio , pagoFinal ;

            Console.WriteLine("La cantidad de litros que lleva el cliente : ");
            litros = int.Parse(Console.ReadLine());

            Console.WriteLine("El precio del litro de producto vendido : ");
            importedeLitro = int.Parse(Console.ReadLine());

            precio = importedeLitro * litros;


            if (litros > 500)
                {
                  pagoFinal = precio * 0.75f;
                } 
            
            else if (litros > 301 && litros <= 500)
                {
                  pagoFinal = precio * 0.85f;
                }
            else if ( litros > 101 && litros <= 300)
                {
                  pagoFinal = precio * 0.90f;
                } 
            else
                {
                  pagoFinal = precio;
                }

            Console.WriteLine("El precio final con el descuento es : $ " + pagoFinal);

            

            // 3.Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar//
            // Para ello existe la siguiente escala de precios //  
            //            i5(1)       i7(2)       i9(3)
            // 8 RAM(1)   USD 800     USD 900     USD 1200
            // 16 RAM(2)  USD 900     USD 1000    USD 1400
            // 32 RAM(3)  USD 1000    USD 1400    USD 2000

            Console.WriteLine("3. Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar");
            Console.WriteLine("Para ello existe la siguiente escala de precios ");
            Console.WriteLine("             i5(1)       i7(2)       i9(3)");
            Console.WriteLine("8 RAM(1)   USD 800     USD 900     USD 1200");
            Console.WriteLine("16 RAM(2)  USD 900     USD 1000    USD 1400");
            Console.WriteLine("32 RAM(3)  USD 1000    USD 1400    USD 2000");

            int notebook, ram, disco ;

            Console.WriteLine("¿Te gustaria tener una nuvea Notebook?");
            Console.WriteLine("Selecciona el procesador deseado 1 (i5), 2 (i7), 3 (i9)");
            notebook = int.Parse(Console.ReadLine());


            switch (notebook)
            {        
                   case 1:
                            Console.WriteLine("Selecciona la RAM 1 (8GB), 2 (16GB), 3 (32GB)");
                            ram = int.Parse(Console.ReadLine());
                   
                   
                                switch (ram)
                                {     
                                       case 1:
                                              precio = 800;
                                       break;

                                       case 2:
                                              precio = 900;
                                       break;
                                          
                                       case 3:
                                              precio = 1000;
                                       break;

                                       default:
                                       break;
                                 }

                            Console.WriteLine("¿Desea extender el disco rigido a 1TB? Nou (0) Yes (1) ");
                            disco = int.Parse(Console.ReadLine());

                            if (disco == 1)
                            {
                                 precio += 300;
                            }
                                   
                    break;

                case 2:
                    Console.WriteLine("Selecciona la RAM 1 (8GB), 2 (16GB), 3 (32GB)");
                    ram = int.Parse(Console.ReadLine());


                    switch (ram)
                    {
                        case 1:
                            precio = 900;
                            break;

                        case 2:
                            precio = 1000;
                            break;

                        case 3:
                            precio = 1400;
                            break;

                        default:
                            break;
                    }

                    Console.WriteLine("¿Desea extender el disco rigido a un 1TB? Nou (0) Yes (1) ");
                    disco = int.Parse(Console.ReadLine());

                    if (disco == 1)
                    {
                        precio += 300;
                    }

                    break;

                case 3:
                    Console.WriteLine("Selecciona la RAM 1 (8GB), 2 (16GB), 3 (32GB)");
                    ram = int.Parse(Console.ReadLine());


                    switch (ram)
                    {
                        case 1:
                            precio = 1200;
                            break;

                        case 2:
                            precio = 1400;
                            break;

                        case 3:
                            precio = 2000;
                            break;

                        default:
                            break;
                    }

                    Console.WriteLine("¿Desea extender el disco rigido a un 1TB? Nou (0) Yes (1) ");
                    disco = int.Parse(Console.ReadLine());

                    if (disco == 1)
                    {
                        precio += 300;
                    }

                    break;

                   default:
                           Console.WriteLine("EROR el numero no es correcto");          
                    break;
            }


            Console.WriteLine("El precio total a pagar es de : $ " + precio);
            Console.WriteLine("Muchas gracias por la compra realizada");



            //4.Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma 
            //de los dos primeros es mayor al producto del segundo con el tercero.

            Console.WriteLine("4.Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma ");
            Console.WriteLine("de los dos primeros es mayor al producto del segundo con el tercero.");

            int a, b, c, resultado1, resultado2;

                Console.WriteLine("Ingresar un numero");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingresar un numero");
                b = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingresar un numero");
                c = int.Parse(Console.ReadLine());

            resultado1 = a + b;
            resultado2 = b * c;

            if (resultado1 > resultado2)
            {
                Console.WriteLine("La suma de a y b es mayor al producto entre b con c ");
            }

            //5.Hacer un programa para ingresar 4 números.Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente
            Console.WriteLine("5.Hacer un programa para ingresar 4 números.Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente");

            int num1, num2, num3, num4, menor = 0;
          

            Console.WriteLine("ingresar un numero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingresar otro numero");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingresar otro numero");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingresar otro numero");
            num4= int.Parse(Console.ReadLine());

            menor = num1;

            if (num2 < num1 && num3 < num2 && num4 < num3)
            {
                Console.WriteLine("Estos numeros están ORDENADOS DECRECIENTES");
            }
            else
                Console.WriteLine("DESORDENADOS");






        }
    }
}
