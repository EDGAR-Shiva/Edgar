﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repositorio
{
    /*programa de herencia, herencia es la caracteristica de pasar 
     * atributos y metodos a otros objetos o clases*/
    //OHHHH DRAMA!!!!!
    //clase mama
    class Operacion
    {
        /*guarda los espacios de memoria de 3 valores*/
        //modificar tipo de dato nombre
        protected   int   valor1;
        protected   int   valor2;
        protected   int   Resultado;

    }
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
