﻿using System;
using System.Data;
using Modelo;
using DAL;


namespace BLL
{
    public class BLLNCMLote
    {
        private DALConexao dalConexao;

        public BLLNCMLote(DALConexao dalConexao)
        {
            this.dalConexao = dalConexao;
        }

        public DataTable Localizar(string valor)
        {
            DALNCMLote dalNCMLote = new DALNCMLote(dalConexao);
            return dalNCMLote.Localizar(valor);
        }

        public void Alterar(ModeloNCM modelo, int apagar)
        {
            if (modelo.CodNCM == "")
            {
                throw new Exception("O código da NCM não pode ficar em branco");
            }

            if (modelo.Cest != "" && modelo.Cest.Trim().Length < 7)
            {
                throw new Exception("O código da CEST se informado deve conter 7 números");
            }

            DALNCMLote dalNcmLote = new DALNCMLote(dalConexao);
            dalNcmLote.Alterar(modelo, apagar);
        }

    }


}
