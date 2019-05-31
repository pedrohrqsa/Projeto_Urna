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
    class clnUrna
    {
        //Para exclusão na lista.
        private string _mesarios, _alunos, _chapas;
        //-------
        private string _adm;

        private string _rm, _senha;

        private string _mesario, _senhamesario, Id_Mesario;

        public string Chapas
        {
            get { return _chapas; }
            set { _chapas = value; }
        }

        public string Alunos
        {
            get { return _alunos; }
            set { _alunos = value; }
        }

        public string Mesarios
        {
            get { return _mesarios; }
            set { _mesarios = value; }
        }
//=======================================================================
        public string idMesario
        {
            get { return Id_Mesario; }
            set { Id_Mesario = value; }
        }

        public string Mesario
        {
            get { return _mesario; }
            set { _mesario = value; }
        }
        public string SenhaMesario
        {
            get { return _senhamesario; }
            set { _senhamesario = value; }
        }
//=======================================================================
        public string Adm
        {
            get { return _adm; }
            set { _adm = value; }
        }

        public string Rm
        {
            get { return _rm; }
            set { _rm = value; }
        }

        public string Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }
//-------------------------------------
        private static string _temp;
        public static string Temp
        {
            get { return _temp; }
            set { _temp = value; }
        }
//-------------------------------------
        public OracleDataReader Valida_ADM(){
            string strQuery = "SELECT * FROM ADMINISTRADOR WHERE ID_ADM='" + _adm + "'";
            CldBancoUrna objBancoDados = new CldBancoUrna();
            return objBancoDados.RetornaDataReader(strQuery);
        }
        public OracleDataReader ValidarRM_e_Senha(){
            string strQuery = "Select senha from alunos where senha='" + _senha + "' and RM='" + _rm + "' and Ativo='1'";
          //string strQuery = "Select senha from alunos where senha='" + _senha + "' and RM='" + _rm + "' and Ativo='1'"; 

            CldBancoUrna objBancoDados = new CldBancoUrna();
            return objBancoDados.RetornaDataReader(strQuery);
        }
        public OracleDataReader Valida_MESARIO(){
            string strQuery = "SELECT * FROM MESARIO WHERE SENHA='" + _senhamesario + "' and ID_MESARIO='" + _mesario + "' and Ativo='1'";
            CldBancoUrna objBancoDados = new CldBancoUrna();
            return objBancoDados.RetornaDataReader(strQuery);
            //SELECT SENHA FROM MESARIO WHERE SENHA='12345' and ID_MESARIO= 'P16'
        }
//----------------------------------------------------------------------------------------------------------------
        //VALIDAÇÃO SE VOTOU OU NÃO.
        public OracleDataReader ValidarVotou(){
            string strQuery = "Select VOTOU_OU_NAO from alunos where Senha='" + _senha + "' and RM='" + _rm + "' and VOTOU_OU_NAO='VOTOU' and Ativo='1'";
            CldBancoUrna objBancoDados = new CldBancoUrna();
            return objBancoDados.RetornaDataReader(strQuery);
        }

        public OracleDataReader ValidarNvotou(){
            string strQuery = "Select VOTOU_OU_NAO from alunos where Senha='" + _senha + "' and RM='" + _rm + "' and VOTOU_OU_NAO='NAO_VOTOU' and Ativo='1'";
            CldBancoUrna objBancoDados = new CldBancoUrna();
            return objBancoDados.RetornaDataReader(strQuery);
        }
//------------------------------------------------------------------------------------------
        public void ConfirmaVoto(){
            string strQuery;
            strQuery = (" UPDATE ALUNOS ");
            strQuery += (" SET ");
            strQuery += (" VOTOU_OU_NAO = 'VOTOU', ");
            strQuery += (" NULO = 'N' ");
            strQuery += (" WHERE ");
            strQuery += (" RM = '" + _rm + "'");
            // UPDATE ALUNOS SET ATIVO = 'VOTOU', NULO = 'S' WHERE RM = '22333'
            CldBancoUrna ObjBancoDados = new CldBancoUrna();
            ObjBancoDados.ExecutaComando(strQuery);
        }

        public void ConfirmaVotoNulo(){
            string strQuery;
            strQuery = (" UPDATE ALUNOS ");
            strQuery += (" SET ");
            strQuery += (" VOTOU_OU_NAO = 'VOTOU', ");
            strQuery += (" NULO = 'S' ");
            strQuery += (" WHERE ");
            strQuery += (" RM = '" + _rm + "'");
            //UPDATE ALUNOS SET NULO = 'S' WHERE RM = ' '
            CldBancoUrna ObjBancoDados = new CldBancoUrna();
            ObjBancoDados.ExecutaComando(strQuery);
        }

//======================================================= CHAPAS ========================================================
        public OracleDataReader Chapa1(){
            string strQuery = "SELECT * FROM CHAPA WHERE COD_CONTAGEM=1";
            CldBancoUrna objBancoDados = new CldBancoUrna();
            return objBancoDados.RetornaDataReader(strQuery);
        }
        public OracleDataReader Chapa2(){
            string strQuery = "SELECT * FROM CHAPA WHERE COD_CONTAGEM=2";
            CldBancoUrna objBancoDados = new CldBancoUrna();
            return objBancoDados.RetornaDataReader(strQuery);
        }
        public OracleDataReader Chapa3(){
            string strQuery = "SELECT * FROM CHAPA WHERE COD_CONTAGEM=3";
            CldBancoUrna objBancoDados = new CldBancoUrna();
            return objBancoDados.RetornaDataReader(strQuery);
        }
        public OracleDataReader Chapa4(){
            string strQuery = "SELECT * FROM CHAPA WHERE COD_CONTAGEM=4";
            CldBancoUrna objBancoDados = new CldBancoUrna();
            return objBancoDados.RetornaDataReader(strQuery);
        }
        public OracleDataReader Chapa5(){
            string strQuery = "SELECT * FROM CHAPA WHERE COD_CONTAGEM=5 ";
            CldBancoUrna objBancoDados = new CldBancoUrna();
            return objBancoDados.RetornaDataReader(strQuery);
        }
//==============================================================================================================
        //SISTEMA DE CONTAGEM "FrmApuracao"
        public OracleDataReader ContaVotosChapa1()
        {
            string strQuery;
            strQuery = "SELECT COUNT (CHAPA_VOTADA) FROM ALUNOS WHERE CHAPA_VOTADA=1 and ativo=1";
            CldBancoUrna ObjBancoDados = new CldBancoUrna();
            return ObjBancoDados.RetornaDataReader(strQuery);
            //SELECT COUNT (CHAPA_VOTADA) FROM ALUNOS WHERE COD_CHAPA_VOTADA=1 and ativo=1;
        }
        public OracleDataReader ContaVotosChapa2()
        {
            string strQuery;
            strQuery = ("SELECT COUNT (CHAPA_VOTADA) FROM ALUNOS WHERE CHAPA_VOTADA=2 and ativo=1");
            CldBancoUrna ObjBancoDados = new CldBancoUrna();
            return ObjBancoDados.RetornaDataReader(strQuery);
        }
        public OracleDataReader ContaVotosChapa3()
        {
            string strQuery;
            strQuery = ("SELECT COUNT (CHAPA_VOTADA) FROM ALUNOS WHERE CHAPA_VOTADA=3 and ativo=1");
            CldBancoUrna ObjBancoDados = new CldBancoUrna();
            return ObjBancoDados.RetornaDataReader(strQuery);
        }
        public OracleDataReader ContaVotosChapa4()
        {
            string strQuery;
            strQuery = ("SELECT COUNT (CHAPA_VOTADA) FROM ALUNOS WHERE CHAPA_VOTADA=4 and ativo=1");
            CldBancoUrna ObjBancoDados = new CldBancoUrna();
            return ObjBancoDados.RetornaDataReader(strQuery);
        }
        public OracleDataReader ContaVotosChapa5()
        {
            string strQuery;
            strQuery = (" SELECT COUNT (CHAPA_VOTADA) FROM ALUNOS WHERE CHAPA_VOTADA=5 and ativo=1");
            CldBancoUrna ObjBancoDados = new CldBancoUrna();
            return ObjBancoDados.RetornaDataReader(strQuery);
        }
        public OracleDataReader ContaVotosNulos()
        {
            string strQuery;
            strQuery = ("SELECT COUNT (NULO) FROM ALUNOS WHERE NULO= 'S' and ativo=1 ");
            CldBancoUrna ObjBancoDados = new CldBancoUrna();
            return ObjBancoDados.RetornaDataReader(strQuery);
        }
        public OracleDataReader ContaPQNV()
        {
            string strQuery;
            strQuery = ("Select count(*) from alunos ");
            strQuery +=("where votou_ou_nao='NAO_VOTOU' and ativo=1");
            CldBancoUrna ObjBancoDados = new CldBancoUrna();
            return ObjBancoDados.RetornaDataReader(strQuery);
        }
//=============================================================//===============================================================
        public OracleDataReader SelecionaChapa1(){
            String strQuery;
            strQuery =  (" UPDATE ALUNOS ");
            strQuery += (" SET ");
            strQuery += (" CHAPA_VOTADA = 1 WHERE ");
            strQuery += (" RM = '" + _rm + "'");
            CldBancoUrna objBancoDados = new CldBancoUrna();
            return objBancoDados.RetornaDataReader(strQuery);
        }

        public OracleDataReader SelecionaChapa2(){
            String strQuery;
            strQuery = (" UPDATE ALUNOS ");
            strQuery += (" SET ");
            strQuery += (" CHAPA_VOTADA = 2 WHERE ");
            strQuery += (" RM = '" + _rm + "'");
            CldBancoUrna objBancoDados = new CldBancoUrna();
            return objBancoDados.RetornaDataReader(strQuery);
        }

        public OracleDataReader SelecionaChapa3(){
            String strQuery;
            strQuery = (" UPDATE ALUNOS ");
            strQuery += (" SET ");
            strQuery += (" CHAPA_VOTADA = 3 WHERE ");
            strQuery += (" RM = '" + _rm + "'");
            CldBancoUrna objBancoDados = new CldBancoUrna();
            return objBancoDados.RetornaDataReader(strQuery);
        }

        public OracleDataReader SelecionaChapa4(){
            String strQuery;
            strQuery = (" UPDATE ALUNOS ");
            strQuery += (" SET ");
            strQuery += (" CHAPA_VOTADA = 4 WHERE ");
            strQuery += (" RM = '" + _rm + "'");
            CldBancoUrna objBancoDados = new CldBancoUrna();
            return objBancoDados.RetornaDataReader(strQuery);
        }
        public OracleDataReader SelecionaChapa5(){
            String strQuery;
            strQuery = ("UPDATE ALUNOS");
            strQuery += (" SET ");
            strQuery += (" CHAPA_VOTADA = 5 WHERE ");
            strQuery += (" RM= '" + _rm + "'");
            CldBancoUrna objBancoDados = new CldBancoUrna();
            return objBancoDados.RetornaDataReader(strQuery);
        }
//==========================================================================================================================
        public void Corrigir()
        {
            string strQuery;
            strQuery = (" UPDATE ALUNOS ");
            strQuery += (" SET ");
            strQuery += (" VOTOU_OU_NAO = 'NAO_VOTOU', ");
            strQuery += (" NULO = 'N' ");
            strQuery += (" WHERE ");
            strQuery += (" RM = '" + _rm + "'");
            CldBancoUrna ObjBancoDados = new CldBancoUrna();
            ObjBancoDados.ExecutaComando(strQuery);
        }
        
        //Função temporária
        public OracleDataReader FuncãoTemporariaCorrigir(){
            String strQuery;
            strQuery = ("UPDATE ALUNOS");
            strQuery += (" SET ");
            strQuery += (" CHAPA_VOTADA = null WHERE");
            strQuery += (" RM= '" + _rm + "'");
            CldBancoUrna objBancoDados = new CldBancoUrna();
            return objBancoDados.RetornaDataReader(strQuery);
        }

        //Exclusão da tela/form "Listar".
        public void ExcluirMesarioLogicamente(){
            string strQuery;
            strQuery = (" UPDATE Mesario ");
            strQuery += (" SET ");
            strQuery += (" Ativo = '0' ");
            strQuery += (" WHERE ");
            strQuery += (" cod_mesario = '" + _mesarios + "'");
            CldBancoUrna ObjCldBancoDados = new CldBancoUrna();
            ObjCldBancoDados.ExecutaComando(strQuery);
           //update Mesario set ativo='0' Where nome=' ';
        }
        public void ExcluirAlunoLogicamente(){
            string strQuery;
            strQuery = (" UPDATE Alunos ");
            strQuery += (" SET ");
            strQuery += (" Ativo = '0' ");
            strQuery += (" WHERE ");
            strQuery += (" cod_alunos = '" + _alunos + "' ");
            CldBancoUrna ObjCldBancoDados = new CldBancoUrna();
            ObjCldBancoDados.ExecutaComando(strQuery);
        }
//=============================================================//========================================================
        //Desativamento das CHAPA E ELEIÇÃO.
        public void LimpaApuracao()
        {
            string strQuery;
            strQuery = ("Update alunos set chapa_votada=null, nulo='N', votou_ou_nao='NAO_VOTOU' ");
            CldBancoUrna ObjCldBancoDados = new CldBancoUrna();
            ObjCldBancoDados.ExecutaComando(strQuery);
        }

        public void DesativarChapas(){
            string strQuery;
            strQuery = ("update chapa set COD_CONTAGEM=0, Ativo=0");
            CldBancoUrna ObjCldBancoDados = new CldBancoUrna();
            ObjCldBancoDados.ExecutaComando(strQuery);
        }
        public void DropSq(){
            string Query;
            Query = ("Drop sequence COD_CONTAGEM_SEQ");
            CldBancoUrna ObjcldBancoUrna = new CldBancoUrna();
            ObjcldBancoUrna.ExecutaComando(Query);
        }
        public void CreateSq()
        {
            string Query;
            Query = (" CREATE SEQUENCE COD_CONTAGEM_SEQ ");
            Query += (" MINVALUE 1 ");
            Query += (" MAXVALUE 5 ");
            Query += (" START WITH 1 ");
            Query += (" INCREMENT BY 1 ");
            Query += (" CACHE 20 " );
            CldBancoUrna ObjcldBancoUrna = new CldBancoUrna();
            ObjcldBancoUrna.ExecutaComando(Query);
        }
    }
}