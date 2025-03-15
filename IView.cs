using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsuariosMVC
{
    public interface IView
    {
        void SetController(Controller controller);
        string Id { get; set; }
        string Nome { get; set; }
        string Sobrenome { get; set; }
        string Setor { get; set; }
        RadioButton Masculino { get; set; }
        RadioButton Feminino { get; set; }

        DataGridView Table { get; set; }

    }

}
