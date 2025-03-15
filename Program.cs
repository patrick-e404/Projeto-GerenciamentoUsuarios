﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsuariosMVC
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FrmUsuarios usuariosView = new FrmUsuarios();
            usuariosView.Visible = false;
            ListaUsuario usuariosModel = new ListaUsuario();
            Controller usuariosController = new Controller(usuariosView, usuariosModel);
            usuariosView.ShowDialog();
        }
    }
}
