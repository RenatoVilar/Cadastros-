﻿using System;
using System.Data;
using DAL;
using Modelo;

namespace BLL
{
    public class BLLNCM
    {
        private DALConexao dalConexao;

        public BLLNCM(DALConexao dalConexao)
        {
            this.dalConexao = dalConexao;
        }

        public void Incluir(ModeloNCM modelo)
        {
            if (modelo.CodNCM.Trim().Length == 0 || modelo.CodNCM.Trim().Length < 8)
            {
                throw new Exception("O código da NCM deve conter 8 números");
            }

            if (modelo.NomeNCM.Trim().Length == 0)
            {
                throw new Exception("O nome da NCM é obrigatório");
            }

            if (modelo.Cest != "" && modelo.Cest.Trim().Length < 7)
            {
                throw new Exception("O código da CEST se informado deve conter 7 números");
            }

            modelo.NomeNCM = modelo.NomeNCM.ToUpper();
            DALNCM dalNCM = new DALNCM(dalConexao);
            dalNCM.Inserir(modelo);
        }

        public void Alterar(ModeloNCM modelo)
        {
            if (modelo.CodNCM.Trim().Length == 0 || modelo.CodNCM.Trim().Length < 8)
            {
                throw new Exception("O código da NCM deve conter 8 números");
            }

            if (modelo.NomeNCM.Trim().Length == 0)
            {
                throw new Exception("O nome da NCM é obrigatório");
            }

            if (modelo.Cest != "" && modelo.Cest.Trim().Length < 7)
            {
                throw new Exception("O código da CEST se informado deve conter 7 números");
            }

            modelo.NomeNCM = modelo.NomeNCM.ToUpper();
            DALNCM dalNCM = new DALNCM(dalConexao);
            dalNCM.Alterar(modelo);
        }

        public void Excluir(int NCMID)
        {
            DALNCM dalNCM = new DALNCM(dalConexao);
            dalNCM.Excluir(NCMID);
        }

        public DataTable Localizar(string valor, int index)
        {
            DALNCM dalNCM = new DALNCM(dalConexao);
            return dalNCM.Localizar(valor, index);
        }

        public ModeloNCM CarregaModeloNCM(int NCMID)
        {
            DALNCM dalNCM = new DALNCM(dalConexao);
            return dalNCM.CarregaModeloNCM(NCMID);
           
        }
    }
}
