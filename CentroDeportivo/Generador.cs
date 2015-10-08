﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeportivo
{
    class Generador
    {
        int id = 0;
        public List<Socio> Socios { get; set; }
        public List<Actividad> Actividades { get; set; }
        public List<Alquiler> Alquileres { get; set; }
        public List<Instalacion> Instalaciones { get; set; }

        List<string> Nombres = new List<string>() { "Santiago", "Mateo", "Sebastian",
        "Alejandro", "Matias", "Diego", "Samuel", "Nicolas", "Daniel", "Martin", "Benjamin",
        "Emiliano", "Leonardo", "Joaquin", "Lucas", "Paloma", "Maria", "Segismunda", "Mercedes", "Sigisfrilda", "Ruka", "Laura", 
        "Paula", "Dominica"};

        List<string> Apellidos = new List<string>() { "Abendano", "Bondia", "Abenhacar", 
        "Bravo", "Costa", "Ximenes", "Barbosa", "Dormido", "Abraham", "Aguero", "Aros",
        "Baiz", "Baez", "Barda", "Baruel", "Cadiz", "Branda", "Diaz", "Pulgar", "Ozorio", 
        "Donate", "Elias", "Garcia", "Wayne"};

        public void generar()
        {
            Socios = new List<Socio>();
            Actividades = new List<Actividad>();
            Alquileres = new List<Alquiler>();
            Instalaciones = new List<Instalacion>();

            for (int i = 0; i < 100; i++)
                generarSocios();

            for (int i = 0; i < 20; i++)
                generarActividades();

            for (int i = 0; i < 12; i++)
                generarInstalaciones();
        }

        public void generarSocios() {
            Random generator = new Random();
            int nombre = generator.Next(Nombres.Count-1);
            int apellido1 = generator.Next(Apellidos.Count - 1);
            int apellido2 = generator.Next(Apellidos.Count - 1);
            StringBuilder Hanz = new StringBuilder();
            Hanz.Append("ES");
            for (int i = 0; i < 22; i++)
            {
                Hanz.Append(generator.Next(9));
            }
            string NombreSocio = Nombres.ToArray()[nombre];
            StringBuilder Franz = new StringBuilder();
            Franz.Append(Apellidos.ToArray()[apellido1]);
            Franz.Append(" ");
            Franz.Append(Apellidos.ToArray()[apellido2]);
            Socios.Add(new Socio(NombreSocio, Franz.ToString(), Hanz.ToString(), 250, id++));
            generator = null;
        }

        public void generarActividades()
        {
            id = 0;

            DateTime start = new DateTime(1995, 1, 1);
            Random gen = new Random();
            int range = (DateTime.Today - start).Days;
            DateTime random = start.AddDays(gen.Next(range));
            DateTime random2 = random.AddDays(gen.Next(25));
            DateTime duracion = random2.AddDays(90);
            Actividades.Add(new Actividad(id++, random, random2, duracion, gen.NextDouble()));
        }

        public void generarAlquileres()
        {

        }

        public void generarInstalaciones()
        {
            id = 0;
            Random generator = new Random();
            double precio = generator.NextDouble();
            Instalaciones.Add(new Instalacion(id++, precio));

        }
    }
}
