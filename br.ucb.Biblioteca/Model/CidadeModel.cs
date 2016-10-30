using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using br.ucb.Biblioteca.DAO;
using br.ucb.Biblioteca.DTO;

namespace br.ucb.Biblioteca.Model
{
    public class CidadeModel
    {
        private CidadeDAO _dao;
        public CidadeModel()
        {
            if (_dao == null)
                _dao = new CidadeDAO();
        }

        public DataSet listarCidadesPorEstado(EstadoDTO dto)
        {
            return _dao.listarCidades(dto);
        }
    }
}
