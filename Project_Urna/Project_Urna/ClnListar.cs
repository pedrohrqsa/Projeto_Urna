using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;

namespace Project_Urna
{
    class ClnListar
    {
        public DataSet ListarMesarios(){
            string strQuery;
            strQuery = "Select cod_mesario, Nome, id_mesario from MESARIO Where Ativo='1' order by cod_mesario";
            //strQuery = "Select * from Mesario";
            CldBancoUrna ObjBancoDados = new CldBancoUrna();
            return ObjBancoDados.RetornaDataSet(strQuery);
       }

        public DataSet ListarAlunos(){
            string strQuery;
            strQuery = "Select cod_alunos, Nome, rm FROM ALUNOS Where Ativo='1' order by cod_alunos";
                      //Select cod_alunos nome, rm, senha FROM ALUNOS Where Ativo='1' order by cod_alunos"
            //strQuery = "Select * from Alunos";
            CldBancoUrna ObjBancoDados = new CldBancoUrna();
            return ObjBancoDados.RetornaDataSet(strQuery);
        }
        public DataSet ListarChapas(){
            String strQuery;
            //strQuery = "Select * from Chapa";
            strQuery = ("select nome_chapa, numero, presidente, vice_presidente, descricao, caminho_foto from chapa where ativo='1'");
            strQuery += (" order by cod_chapa");
            CldBancoUrna ObjBancoDados = new CldBancoUrna();
            return ObjBancoDados.RetornaDataSet(strQuery);
        }

        //para o projeto web
        //public DataSet ListarMesarios1()
        //{
        //    string strQuery;
        //    strQuery = "Select nome, id_mesario, Senha from MESARIO ";
        //    //strQuery = "Select * from Mesario";
        //    CldBancoUrna ObjBancoDados = new CldBancoUrna();
        //    return ObjBancoDados.RetornaDataSet(strQuery);
        //}
    }
}
