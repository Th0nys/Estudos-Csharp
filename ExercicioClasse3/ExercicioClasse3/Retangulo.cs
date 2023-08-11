﻿using System;

namespace ExercicioClasse3
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }

        public override string ToString()
        {
            return $"AREA = {Area().ToString("F2")}\nPERIMETRO: {Perimetro().ToString("F2")}\nDIAGONAL: {Diagonal().ToString("F2")}";
        }
    }

}
