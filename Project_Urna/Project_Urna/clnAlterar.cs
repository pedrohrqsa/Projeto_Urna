using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Oracle.DataAccess;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Project_Urna
{
    class clnAlterar
    {
        //Para alteração do mesário
        string cod, nomem, idm, senham;

        public string SenhaM
        {
            get { return senham; }
            set { senham = value; }
        }

        public string idM
        {
            get { return idm; }
            set { idm = value; }
        }

        public string NomeM
        {
            get { return nomem; }
            set { nomem = value; }
        }

        public string Cod
        {
            get { return cod; }
            set { cod = value; }
        }        

    //---------------------------------------------------------------
        //Para Alteração do aluno
        // getters and setters

        private string _coda, _nomedoaluno, _rm, _senhaa;

        public string editRM
        {
            get { return _rm; }
            set { _rm = value; }
        }

        public string SenhaA
        {
            get { return _senhaa; }
            set { _senhaa = value; }
        }

        public string NomedoAluno
        {
            get { return _nomedoaluno; }
            set { _nomedoaluno = value; }
        }

        public string CodA
        {
            get { return _coda; }
            set { _coda = value; }
        }

        //---------------------------------------------------------------
        //Para alteração das chapas
        //getters and setters
        private string 
            _codchapa,
            _editnomechapa,
            _editnumerochapa,
            _editpresidente,
            _editvicepresidente,
            _editdescricao,
            _editcaminhodafoto;

        public string EditCaminhoDaFoto
        {
            get { return _editcaminhodafoto; }
            set { _editcaminhodafoto = value; }
        }

        public string EditDescricao
        {
            get { return _editdescricao; }
            set { _editdescricao = value; }
        }

        public string Editvicepresidente
        {
            get { return _editvicepresidente; }
            set { _editvicepresidente = value; }
        }

        public string EditPresidente
        {
            get { return _editpresidente; }
            set { _editpresidente = value; }
        }

        public string EditNmrChapa
        {
            get { return _editnumerochapa; }
            set { _editnumerochapa = value; }
        }

        public string EditNomeChapa
        {
            get { return _editnomechapa; }
            set { _editnomechapa = value; }
        }

        public string CodChapa
        {
            get { return _codchapa; }
            set { _codchapa = value; }
        }
        //---------------------------------------------------------------
        //Preenche textBox
        //Métodos que validar código e carregar seleção de edição desejada
        public OracleDataReader SelectCodM()
        {
            string EditaM;
            EditaM = "Select cod_mesario from mesario where cod_mesario=" + Cod + " and ativo=1";
            //Select cod_mesario from mesario where cod_mesario='1' and ativo=1
            CldBancoUrna objEditDados = new CldBancoUrna();
            return objEditDados.RetornaDataReader(EditaM);
        }

        public OracleDataReader SelectM()
        {
            string SelectM;
            SelectM = "Select nome, id_mesario, senha from mesario where cod_Mesario ='" + Cod + "' and ativo=1";
            //Select cod_mesario from mesario where cod_mesario='1' and ativo=1
            CldBancoUrna objEditDados = new CldBancoUrna();
            return objEditDados.RetornaDataReader(SelectM);
        }
        public void EditaMesario()
        {
            string strQuery;
            strQuery = ("Update mesario set nome='" + NomeM + "', id_mesario='" + idM + "', ");
            strQuery += ("senha=" + SenhaM + " Where cod_mesario=" + Cod + " and Ativo=1 ");
            //Update Mesario set nome='  Pedro Henrique', id_mesario='     P33       ', senha='     12345       ';
            CldBancoUrna ObjcldBancoUrna = new CldBancoUrna();
            ObjcldBancoUrna.ExecutaComando(strQuery);
        }

        //=====================================================
        public OracleDataReader SelectCodA()
        {
            string SelectCodA;
            SelectCodA = "Select cod_alunos from alunos where cod_alunos=" + CodA + " and ativo=1 ";
            CldBancoUrna objEditDados = new CldBancoUrna();
            return objEditDados.RetornaDataReader(SelectCodA);
        }
        public OracleDataReader SelectA()
        {
            string SelectA;
            SelectA = "Select Nome, rm, senha from alunos where cod_alunos="+ CodA +" and ativo=1 ";
            //         Select Nome, rm, senha from alunos where cod_alunos=    4      and ativo=1;
            CldBancoUrna objEditDados = new CldBancoUrna();
            return objEditDados.RetornaDataReader(SelectA);
        }
        public void EditaAluno()
        {
            string strQuery;
            strQuery = (" Update Alunos set nome='" + NomedoAluno + "', rm=" + editRM + ", senha='" + SenhaA + "' ");
            strQuery += ("Where cod_alunos=" + CodA + " and Ativo=1 ");
            //update Alunos set nome='Pedro', rm=26517, senha=' pedroh' Where cod_alunos=4;
            CldBancoUrna ObjcldBancoUrna = new CldBancoUrna();
            ObjcldBancoUrna.ExecutaComando(strQuery);
        }

        //=====================================================
        public OracleDataReader SelectCodC()
        {
            string EditaC;
            EditaC = ("Select cod_chapa from Chapa");
            EditaC += (" where cod_chapa="+ CodChapa +" ");
            CldBancoUrna objEditaDados = new CldBancoUrna();
            return objEditaDados.RetornaDataReader(EditaC);
        }
        public OracleDataReader SelectC()
        {
            string SelectC;
            SelectC =  ("Select cod_chapa, nome_chapa, numero, ");
            SelectC += ("presidente, vice_presidente, descricao, caminho_foto ");
            SelectC += ("from chapa ");
            SelectC += ("where cod_chapa=" + CodChapa +" ");
            SelectC += ("and ativo=1");
            CldBancoUrna objEditDados = new CldBancoUrna();
            return objEditDados.RetornaDataReader(SelectC);
        }

        public void EditC()
        {
            string Query;
            Query = ("update chapa set ");
            Query += ("nome_chapa='" + EditNomeChapa + "',");
            //QueryE += ("numero=" + EditNmrChapa + ", ");
            Query += ("presidente='" + EditPresidente + "', ");
            Query += ("vice_presidente='" + Editvicepresidente + "', ");
            Query += ("descricao='" + EditDescricao + "', ");
            Query += ("caminho_foto='" + EditCaminhoDaFoto + "' ");
            Query += ("where cod_chapa=" + CodChapa + " and ativo=1");

            //QueryGravar.Append(" ");
            CldBancoUrna ObjCldBancoDados = new CldBancoUrna();
            ObjCldBancoDados.ExecutaComando(Query);
        }
    }
}

//public void EditaChapa()
//{
//    string strQuery;
//    strQuery = (" ");
//    //Query para testar
//    CldBancoUrna ObjcldBancoUrna = new CldBancoUrna();
//    ObjcldBancoUrna.ExecutaComando(strQuery);
//}