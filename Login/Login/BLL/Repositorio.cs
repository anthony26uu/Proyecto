﻿using Login.DAL;
using Login.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Windows.Forms;

namespace Login.BLL
{
   
  public class Repositorio<TEntity> : IRepository<TEntity> where TEntity : class
    {
        RegistroDb context = null;

        public Repositorio()
        {
            context = new RegistroDb();
        }
        
        private DbSet<TEntity> EntitySet
        {
            get
            {
                return context.Set<TEntity>();
            }
        }

        public TEntity Guardar(TEntity n)
        {
           try
            {
          

                EntitySet.Add(n);
                context.SaveChanges();
                return  n;

            }
            catch (Exception )
            {
               
                throw;
            }
            return null;
        }

    
        public TEntity Buscar(Expression<Func<TEntity, bool>> id)
        {
            TEntity retorno = null;
            try
            {
                retorno = EntitySet.FirstOrDefault(id);
            }
            catch (Exception)
            {

                throw;
            }
            return retorno;
        }

        public bool Eliminar(TEntity id)
        {
            bool result = false;
            try
            {
                EntitySet.Attach(id);
                EntitySet.Remove(id);
                result = context.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public List<TEntity> GetList()
        {

            try
            {
                return EntitySet.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TEntity> GetListNombre(Expression<Func<TEntity, bool>> nombre)
        {
            try
            {
                return EntitySet.Where(nombre).ToList();
            }
            catch (Exception)
            {

                throw;
            }


        }

        public List<TEntity> GetListFecha(Expression<Func<TEntity, bool>> fecha)
        {
            try
            {
                return EntitySet.Where(fecha).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Dispose()
        {
            if (context != null)
            {
                context.Dispose();
            }
        }
    }
}
