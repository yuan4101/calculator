﻿using System;

namespace libServices
{
    public class clsConsola
    {
        public static void limpiarScreen()
        {
            Console.Clear();
        }
        public static void EsperarKey()
        {
            Console.ReadKey();
        }
        public static void Pausa(string prmTexto)
        {
            EscribirLN("\n" + prmTexto);
            EsperarKey();
            limpiarScreen();
        }
        public static void EscribirLN<Tipo>(Tipo prmContenido)
        {
            Console.WriteLine(prmContenido);
        }
        public static void Escribir<Tipo>(Tipo prmContenido)
        {
            Console.Write(prmContenido);
        }
        public static void EscribirEncabezado(string prmTexto)
        {
            EscribirLN("------------------------------------------------------------------------");
            EscribirLN(prmTexto);
            EscribirLN("------------------------------------------------------------------------");
        }
        public static string Leer()
        {
            return Console.ReadLine();
        }
        public static string Leer (string prmEtiqueta)
        {
            Escribir(prmEtiqueta);
            return Leer();
        }
        public static Tipo Leer<Tipo>(string prmEtiqueta)
        {
            do
            {
                try { return (Tipo)Convert.ChangeType(Leer(prmEtiqueta), typeof(Tipo)); }
                catch (Exception e) { EscribirEncabezado("ERROR: " + e.Message); }
            } while (true);
        }
    }
}