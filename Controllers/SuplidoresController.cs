﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AgroVeterinariaSoft.Data;
using AgroVeterinariaSoft.Models;
using Microsoft.EntityFrameworkCore;

namespace AgroVeterinariaSoft.Controllers
{
    public class SuplidoresController
    {
        public static bool Guardar(Suplidores Suplidor)
        {
            bool paso = false;
            Contexto Database = new Contexto();
            try
            {
                if(Suplidor.CodigoSuplidor==0)
                {
                    Insertar(Suplidor);
                }
                else
                {
                    Modificar(Suplidor);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }
        public static bool Insertar(Suplidores Suplidor)
        {
            Contexto Database = new Contexto(); 
            bool paso = false;

            try
            {
                Database.Suplidores.Add(Suplidor);
                paso = Database.SaveChanges() > 0;

            }
            catch (Exception)
            {

                throw;
            }
            Database.Dispose();

            return paso;
        }

        public static bool Modificar(Suplidores Suplidor)
        {
            Contexto Database = new Contexto();
            bool paso = false;
            try
            {
                Database.Entry(Suplidor).State = EntityState.Modified;
                paso = Database.SaveChanges()>0;
            }
            catch (Exception)
            {

                throw;
            }
            Database.Dispose();

            return paso;
           
        }

        public static Suplidores Buscar(int Id)
        {
            Suplidores Suplidor;
            Contexto Database = new Contexto();

            try
            {
                Suplidor = Database.Suplidores.Find(Id);
            }
            catch (Exception)
            {

                throw;
            }
            Database.Dispose();

            return Suplidor;
        }

        public static bool Eliminar(int Id)
        {
            bool paso=false;
           
            Contexto Database = new Contexto();

            try
            {
                Suplidores Suplidor = Database.Suplidores.Find(Id);
                Database.Suplidores.Remove(Suplidor);
                if(Database.SaveChanges()>0)
                {
                    paso = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            Database.Dispose();

            return paso;

        }

        public static List<Suplidores> GetList(Expression<Func<Suplidores,bool>>expression)
        {
            Contexto Database = new Contexto();
            List<Suplidores> Lista;

            try
            {
                Lista = Database.Suplidores.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return Lista;
        }
    }
}
