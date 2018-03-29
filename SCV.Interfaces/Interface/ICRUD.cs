using SCV.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCV.Domain.Interface
{
    /// <summary>
    /// Interface Genérica para base de CRUD
    /// </summary>
    /// <typeparam name="T">Tipo de Entidade</typeparam>
    public interface ICRUD<T>
    {
        T Criar(T objeto);     
        void Atualizar(T objeto); 
        void Excluir(T objeto);
    }
}
