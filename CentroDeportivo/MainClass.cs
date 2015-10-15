﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeportivo
{
    public class MainClass
    {
        static Generador gn;
        static int Main(string[] args)
        {
            printList();
            return 0;
        }

        public static void printList()
        {
            gn = new Generador();
            gn.generar();
         /*   Console.WriteLine("Socios:\n");
            var sc = gn.Socios;
            for (int i = 0; i < gn.Socios.Count; i++ )
                System.Console.WriteLine(gn.Socios.ToArray()[i]);

            Console.WriteLine("Instalaciones:\n");
            foreach (Instalacion ic in gn.Instalaciones)
                System.Console.WriteLine(ic);

            Console.WriteLine("Actividades:\n");
            foreach (Actividad ac in gn.Actividades)
                System.Console.WriteLine(ac);
            */
            Control cs = new Control();
            Socio test1 = new Socio("Andrei", "Manu", "ES0022558812121349294012", 120, 1);
            cs.SignUp(test1);
            foreach(Socio soc in cs.db.Socios)
                System.Console.WriteLine(soc);
            cs.Remove(test1);
            if (cs.db.Socios.Count == 0)
                System.Console.WriteLine("Database is empty");
            foreach (Socio soc in cs.db.Socios)
                System.Console.WriteLine(soc);


        }
    }
}