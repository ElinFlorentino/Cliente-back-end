using ClienteBackEnd.Data.Models;
using ClienteBackEnd.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteBackEnd.Data.services
{
    public class ClienteService
    {
        private AppDbContext _context;
        public ClienteService(AppDbContext context)
        {
            _context = context;
        }

        public void addCliente(ClienteVM cliente)
        {
            var _cliente = new Cliente()
            {
                Name = cliente.Name,
                LastName = cliente.LastName
            };
            _context.Cliente.Add(_cliente);
            _context.SaveChanges();
        }

        public List<Cliente> GetAllClientes() => _context.Cliente.ToList();

        //public Cliente GetClientesById(int id) => _context.Cliente.FirstOrDefault(n => n.Id == id);

        public Cliente updateClienteById(int id, ClienteVM cliente)
        {
            var _cliente = _context.Cliente.FirstOrDefault(n => n.Id == id);
            if(_cliente != null)
            {
                _cliente.Name = cliente.Name;
                _cliente.LastName = cliente.LastName;

                _context.SaveChanges();
            }

            return _cliente;
        }

        public void deleteClieteById(int id)
        {
            var _cliente = _context.Cliente.FirstOrDefault(n => n.Id == id);
            if (_cliente != null)
            {
                _context.Cliente.Remove(_cliente);
                _context.SaveChanges();
            }
        }
 
    }
}
