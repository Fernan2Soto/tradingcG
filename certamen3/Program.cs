using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace certamen3
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader sr = new StreamReader("data.txt");
            string line = sr.ReadLine();
            List<data> datos = new List<data>();
            data[] arrayData = new data[200];

            int contador = 0;
            while (line != null)
            {
                var dataLinea = line.Split(';');


                arrayData[contador] = new data();
                arrayData[contador].APERTURA = double.Parse(dataLinea[0]);
                arrayData[contador].MAXIMO = double.Parse(dataLinea[1]);
                arrayData[contador].MINIMO = double.Parse(dataLinea[2]);
                arrayData[contador].CIERRE = double.Parse(dataLinea[3]);

                line = sr.ReadLine();
                contador++;
            }
            contador = 10;
            double Amayor = arrayData[0].APERTURA;
            double Amenor = arrayData[0].APERTURA;

            double Mmayor = arrayData[0].MAXIMO;
            double Mmenor = arrayData[0].MAXIMO;

            double MImayor = arrayData[0].MINIMO;
            double MImenor = arrayData[0].MINIMO;

            double Cmayor = arrayData[0].CIERRE;
            double Cmenor = arrayData[0].CIERRE;

            for (int i = 10; i < 190; i++)
            {
                //APERTURA
                for (int j = i - 10; j <= i; j++)
                {
                    if (arrayData[i].APERTURA > arrayData[j].APERTURA && Amayor < arrayData[j].APERTURA)
                    {
                        for (int k = i; k <= i + 10; k++)
                        {
                            if (arrayData[i].APERTURA > arrayData[k].APERTURA && Amayor > arrayData[k].APERTURA)
                            {
                                Amayor = arrayData[i].APERTURA;
                            }
                        }
                    }
                }
                for (int j = i - 10; j <= i; j++)
                {
                    if (arrayData[i].APERTURA < arrayData[j].APERTURA && Amenor > arrayData[j].APERTURA)
                    {
                        for (int k = i; k <= i + 10; k++)
                        {
                            if (arrayData[i].APERTURA < arrayData[k].APERTURA && Amenor < arrayData[k].APERTURA)
                            {
                                Amenor = arrayData[i].APERTURA;
                            }
                        }
                    }
                }
                //MAXIMA
                for (int j = i - 10; j <= i; j++)
                {
                    if (arrayData[i].MAXIMO > arrayData[j].MAXIMO && Mmayor < arrayData[j].MAXIMO)
                    {
                        for (int k = i; k <= i + 10; k++)
                        {
                            if (arrayData[i].MAXIMO > arrayData[k].MAXIMO && Mmayor > arrayData[k].MAXIMO)
                            {
                                Mmayor = arrayData[i].MAXIMO;
                            }
                        }
                    }
                }
                for (int j = i - 10; j <= i; j++)
                {
                    if (arrayData[i].MAXIMO < arrayData[j].MAXIMO && Mmenor > arrayData[j].MAXIMO)
                    {
                        for (int k = i; k <= i + 10; k++)
                        {
                            if (arrayData[i].MAXIMO < arrayData[k].MAXIMO && Mmenor < arrayData[k].MAXIMO)
                            {
                                Mmenor = arrayData[i].MAXIMO;
                            }
                        }
                    }
                }
                //MINIMO
                for (int j = i - 10; j <= i; j++)
                {
                    if (arrayData[i].MINIMO > arrayData[j].MINIMO && MImayor < arrayData[j].MINIMO)
                    {
                        for (int k = i; k <= i + 10; k++)
                        {
                            if (arrayData[i].MINIMO > arrayData[k].MINIMO && MImayor > arrayData[k].MINIMO)
                            {
                                MImayor = arrayData[i].MINIMO;
                            }
                        }
                    }
                }
                for (int j = i - 10; j <= i; j++)
                {
                    if (arrayData[i].MINIMO < arrayData[j].MINIMO && MImenor > arrayData[j].MINIMO)
                    {
                        for (int k = i; k <= i + 10; k++)
                        {
                            if (arrayData[i].MINIMO < arrayData[k].MINIMO && MImenor < arrayData[k].MINIMO)
                            {
                                MImenor = arrayData[i].MINIMO;
                            }
                        }
                    }
                }

                //CIERRE
                for (int j = i - 10; j <= i; j++)
                {
                    if (arrayData[i].CIERRE > arrayData[j].CIERRE && Cmayor < arrayData[j].CIERRE)
                    {
                        for (int k = i; k <= i + 10; k++)
                        {
                            if (arrayData[i].CIERRE > arrayData[k].CIERRE && Cmayor > arrayData[k].CIERRE)
                            {
                                Cmayor = arrayData[i].CIERRE;
                            }
                        }
                    }
                }
                for (int j = i - 10; j <= i; j++)
                {
                    if (arrayData[i].CIERRE < arrayData[j].CIERRE && Cmenor > arrayData[j].CIERRE)
                    {
                        for (int k = i; k <= i + 10; k++)
                        {
                            if (arrayData[i].CIERRE < arrayData[k].CIERRE && Cmenor < arrayData[k].CIERRE)
                            {
                                Cmenor = arrayData[i].CIERRE;
                            }
                        }
                    }
                }

            }
            Console.WriteLine("APERTURA");
            Console.WriteLine("Maxima :    " + Amayor);
            Console.WriteLine("Minimo :    " + Amenor);
            Console.WriteLine();
            Console.WriteLine("MAXIMA");
            Console.WriteLine("Maxima :    " + Mmayor);
            Console.WriteLine("Minimo :    " + Mmenor);
            Console.WriteLine();
            Console.WriteLine("MINIMA");
            Console.WriteLine("Maxima :    " + MImayor);
            Console.WriteLine("Minimo :    " + MImenor);
            Console.WriteLine();
            Console.WriteLine("CIERRE");
            Console.WriteLine("Maxima :    " + Cmayor);
            Console.WriteLine("Minimo :    " + Cmenor);
            Console.ReadKey();

        }
    }

}
    

