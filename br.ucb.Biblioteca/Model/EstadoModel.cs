using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using br.ucb.Biblioteca.DAO;

namespace br.ucb.Biblioteca.Model
{
    public class EstadoModel
    {
        private EstadoDAO _dao;

        public EstadoModel()
        {
            if (_dao == null)
                _dao = new EstadoDAO();
        }
        public DataSet listarEstados()
        {
            return _dao.listarEstados();
        }
    }
}
