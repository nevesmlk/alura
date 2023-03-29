﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using byteBankAlura.Funcionarios;
using byteBankAlura.SistemaInterno;

namespace byteBankAlura.Funcionarios 
{
    public class Diretor : FuncionarioAutenticavel
    {


        public override double GetBonificacao()
        {
            return salario;
        }
        public Diretor(string cpf) : base(cpf, 5000)
        {

        }
        public override void AumentarSalario()
        {
            this.salario *= 1.15;
        }

    }
}
