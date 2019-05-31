using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Project_Urna
{
    class Cln_inserir
    {
        //Para o Cadastro do mesário
        private string _NomeMesario, _id_Mesario, _senha_mesario;

        public string Senha_Mesario
        {
            get { return _senha_mesario; }
            set { _senha_mesario = value; }
        }

        public string Id_Mesario
        {
            get { return _id_Mesario; }
            set { _id_Mesario = value; }
        }

        public string NomeMesario
        {
            get { return _NomeMesario; }
            set { _NomeMesario = value; }
        }
//==========================================================
        //Para o Cadastro da chapa
        private string _NOMECHAPA, _NUMEROCHAPA, _PRESIDENTECHAPA, _VICEPRESIDENTECHAPA, _DESCRICAO_CHAPA, CAMINHO_FOTO;

        public string Caminho_Foto
        {
            get { return CAMINHO_FOTO; }
            set { CAMINHO_FOTO = value; }
        }

        public string DescricaoChapa
        {
            get { return _DESCRICAO_CHAPA; }
            set { _DESCRICAO_CHAPA = value; }
        }

        public string VicePresidenteChapa
        {
            get { return _VICEPRESIDENTECHAPA; }
            set { _VICEPRESIDENTECHAPA = value; }
        }

        public string Presidente_Chapa
        {
            get { return _PRESIDENTECHAPA; }
            set { _PRESIDENTECHAPA = value; }
        }

        public string Numero_Chapa
        {
            get { return _NUMEROCHAPA; }
            set { _NUMEROCHAPA = value; }
        }

        public string Nome_Chapa
        {
            get { return _NOMECHAPA; }
            set { _NOMECHAPA = value; }
        }
//=====================================================================
        //Para o Cadastro do aluno
        private string NomeAluno, rm, SenhaAluno;

        public string Senha_Aluno
        {
            get { return SenhaAluno; }
            set { SenhaAluno = value; }
        }
        public string RM
        {
            get { return rm; }
            set { rm = value; }
        }
        public string Nome_Aluno
        {
            get { return NomeAluno; }
            set { NomeAluno = value; }
        }
//====================================================================
       public void SalvarMesario() 
       {
            StringBuilder QueryGravar = new StringBuilder();
            QueryGravar.Append(" INSERT INTO MESARIO (COD_MESARIO, ");
            QueryGravar.Append(" NOME, ID_MESARIO, SENHA, ATIVO) ");
            QueryGravar.Append(" VALUES (");
            QueryGravar.Append(" MESARIO_SEQ.NEXTVAL,");
            QueryGravar.Append("'" + _NomeMesario+ "',");
            QueryGravar.Append("'" + _id_Mesario + "',");
            QueryGravar.Append("'" + _senha_mesario + "',");
            QueryGravar.Append(" '1' ");
            QueryGravar.Append(")");
           //INSERT INTO MESARIO (COD_MESARIO, NOME, ID_MESARIO, SENHA) VALUES (MESARIO_SEQ.NEXTVAL, 'Pedro Henrique', 'P16','12345');
           CldBancoUrna ObjCldBancoDados = new CldBancoUrna();
           ObjCldBancoDados.ExecutaComando(QueryGravar.ToString());
       }

        public void SalvarAluno()
        {
            StringBuilder QueryGravar = new StringBuilder();
            QueryGravar.Append(" INSERT INTO ALUNOS (COD_ALUNOS,");
            QueryGravar.Append(" NOME, RM, SENHA, ATIVO)");
            QueryGravar.Append(" VALUES (");
            QueryGravar.Append(" ALUNOS_SEQ.NEXTVAL,");
            QueryGravar.Append("'" + Nome_Aluno + "',");
            QueryGravar.Append("'" + rm + "',");
            QueryGravar.Append("'" + Senha_Aluno + "',");
            QueryGravar.Append(" '1' ");
            QueryGravar.Append(")");
            //INSERT INTO ALUNOS (COD_RM_ALUNOS, NOME, RM, SENHA, ATIVO) VALUES (RM_ALUNOS_SEQ.NEXTVAL, 'Pedro Henrique', '26515', 'pedro','1');
            CldBancoUrna ObjCldBancoDados = new CldBancoUrna();
            ObjCldBancoDados.ExecutaComando(QueryGravar.ToString());
        }

        public void SalvarChapa()
        {
            StringBuilder QueryGravar = new StringBuilder();
            QueryGravar.Append(" INSERT INTO CHAPA (COD_CHAPA, COD_CONTAGEM, ");
            QueryGravar.Append(" NOME_CHAPA, NUMERO, ");
            QueryGravar.Append(" PRESIDENTE, VICE_PRESIDENTE, ");
            QueryGravar.Append(" DESCRICAO, CAMINHO_FOTO, ATIVO) ");
            QueryGravar.Append(" VALUES (");
            QueryGravar.Append(" COD_CHAPA_SEQ.NEXTVAL, ");
            QueryGravar.Append(" COD_CONTAGEM_SEQ.NEXTVAL, ");
            QueryGravar.Append("'" + _NOMECHAPA + "',");
            QueryGravar.Append("'" + _NUMEROCHAPA + "',");
            QueryGravar.Append("'" + _PRESIDENTECHAPA + "',");
            QueryGravar.Append("'" + _VICEPRESIDENTECHAPA + "',");
            QueryGravar.Append("'" + _DESCRICAO_CHAPA + "',");
            QueryGravar.Append("'" + CAMINHO_FOTO + "'");
            QueryGravar.Append(", '1' ");
            QueryGravar.Append(")");
            CldBancoUrna ObjCldBancoDados = new CldBancoUrna();
            ObjCldBancoDados.ExecutaComando(QueryGravar.ToString());
        }

        public void SalvarComData()
        {
            StringBuilder Gravar = new StringBuilder();
            Gravar.Append("insert into Hora_Data_Chapa (codpr, cod_chapa, nome_chapa, inserido_hora, inserido_data)");
            Gravar.Append(" values ");
            Gravar.Append("(codpr_seq.nextval, codchapa_seq.Nextval, '" + _NOMECHAPA + "',");
            Gravar.Append(" '" + DateTime.Now.ToString("HH:mm:ss") + "',");
            Gravar.Append(" '" + DateTime.Now.ToString("dd/MM/yyyy") + "')");
            CldBancoUrna ObjCldBancoDados = new CldBancoUrna();
            ObjCldBancoDados.ExecutaComando(Gravar.ToString());
        }

        public void Salvar()
        {
            StringBuilder Query = new StringBuilder();
            Query.Append("  ");
            CldBancoUrna objCld = new CldBancoUrna();
            objCld.ExecutaComando(Query.ToString());
        }
    }
}