using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCV.Domain.Interface
{
    public interface ISelecao<T>
    {
        IEnumerable<T> SelecionarTodos();
        T SelecionarPorID(int idObjeto);   
    }
}
