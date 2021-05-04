using CarManager0323.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323.DB
{
     class DaoOracle
    {
        const string CONNECT_ERR = "DB 접속";
        const string DISCONNECT_ERR = "접속 해제";
        const string CREATE_TB_ERR = "테이블 시퀀스 생성";
        const string DROP_TB_ERR = "테이블 시퀀스 삭제";

        const string ORADB = "Data Source = (DESCRIPTION=(ADDRESS_LIST="
            +"(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)"
            +"(PORT=1521)))"
            + "(CONNECT_DATA=(SERVER=DEDICATED)"
            + "(SERVICE_NAME=XE)));"
            + "User Id=c##scott;Password=1126;";

        OracleConnection conn;
        OracleCommand cmd;

        public DaoOracle()
        {
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
            dbConnect();
        }

        //소멸자(C++ 에서 많이 사용) Java에서는 없음
        ~DaoOracle()
        {
            dbClose();
        }

        public void dbConnect()
        {
            try
            {
                conn.Open();
                Console.WriteLine("오라클 접속 성공");
            }
            catch (OracleException e)
            {
                errorMsg(CONNECT_ERR, e);
            }
           
        }

        public void dbClose()
        {
            try
            {
                conn.Close();
                Console.WriteLine("오라클 접속 해제");
            }
            catch (OracleException e)
            {
                errorMsg(DISCONNECT_ERR, e);
            }
            

        }


        public void createTable()
        {
            try
            {
                string query = "create table testTB (" +
               "id number not null," +
               "name varchar(20) not null," +
               "age number not null," +
               "constraint pk_testTB_id primary key(id))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "create sequence seq_testTB_id " +
                    "increment by 1 start with 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공");
            }
            catch (OracleException e)
            {

                errorMsg(CREATE_TB_ERR, e);
            }
           
        }

        public void errorMsg(string msg,OracleException e)
        {
            Console.WriteLine(msg+":에러번호"+ e.Number);
            Console.WriteLine(msg + ":에러내용" + e.Message);
        }


        public void makeTbCar()
        {
            try
            {
                string query = "CREATE TABLE car_t("
                    + "carNum    INT             NOT NULL,"
                    + "year      VARCHAR2(20)    NOT NULL,"
                    + "model     VARCHAR2(20)    NOT NULL,"
                    + "money     INT             NOT NULL,"
                    + "color     VARCHAR2(20)    NOT NULL,"
                    + "CONSTRAINT CAR_T_PK PRIMARY KEY(carNum))";


                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "CREATE SEQUENCE car_t_SEQ "
                        + "START WITH 1 "
                        + "INCREMENT BY 1";

                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공");
            }
            catch (OracleException e)
            {

                errorMsg(CREATE_TB_ERR, e);
            }
        }



        public void makeTbCustomer()
        {
            try
            {
                string query = "CREATE TABLE customer_t (" +
               "ctmNum INT             NOT NULL," +
               "ctmName VARCHAR2(20)    NOT NULL," +
               "ctmAddress    VARCHAR2(40)    NOT NULL," +
               "ctmTel        VARCHAR2(20)    NOT NULL,"+
               "ctmEmail      VARCHAR2(40)    NULL," +
               "CONSTRAINT CUSTOMER_T_PK PRIMARY KEY(ctmNum))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                


                string querySeq = "CREATE SEQUENCE customer_t_SEQ " +
                    "START WITH 1 INCREMENT BY 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공");
            }
            catch (OracleException e)
            {

                errorMsg(CREATE_TB_ERR, e);
            }
        }

        

    
    



    
    

        public void makeTbSeller()
        {
            try
            {
                string query = "CREATE TABLE seller_t (" +
               "sellNum INT             NOT NULL," +
               "sellName VARCHAR2(20)    NOT NULL," +
               "sellTel      VARCHAR2(20)    NOT NULL," +
               "sellEmail    VARCHAR2(20)    NOT NULL," +
               "agent        VARCHAR2(20)    NULL, " +
               "position VARCHAR2(20)    NULL, " +
               "CONSTRAINT SELLER_T_PK PRIMARY KEY(sellNum))";

                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();


                string querySeq = " CREATE SEQUENCE seller_t_SEQ " +
                    "START WITH 1 INCREMENT BY 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공");
            }
            catch (OracleException e)
            {

                errorMsg(CREATE_TB_ERR, e);
            }
        }

        

        public void makeTbDeal()
        {
            try
            {
                string query = "CREATE TABLE trade_t(" +
               "trdNum INT             NOT NULL," +
               "ctmNum INT             NOT NULL," +
               "carNum INT             NOT NULL," +
               "sellNum INT             NOT NULL," +
               "trdDate VARCHAR2(20)    NOT NULL," +
               "CONSTRAINT TRADE_T_PK PRIMARY KEY(trdNum)," +
               "CONSTRAINT FK_trade_t_ctmNum_customer_t_c FOREIGN KEY(ctmNum)" +
               " REFERENCES customer_t(ctmNum)," +
               "CONSTRAINT FK_trade_t_carNum_car_t_carNum FOREIGN KEY (carNum)" +
               " REFERENCES car_t (carNum)," +
               "CONSTRAINT FK_trade_t_sellNum_seller_t_se FOREIGN KEY (sellNum)" +
               " REFERENCES seller_t (sellNum))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                


                string querySeq = "CREATE SEQUENCE trade_t_SEQ " +
                    "INCREMENT BY 1 START WITH 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공");
            }
            catch (OracleException e)
            {

                errorMsg(CREATE_TB_ERR, e);
            }
        }
        



        public void dropTable()
        {
            try
            {
                string query = "drop table testTB";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "drop sequence seq_testTB_id";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 삭제 성공");
            }
            catch (OracleException e)
            {

                errorMsg(DROP_TB_ERR, e);
            }
            
        }
        public void createAllTB()
        {
            makeTbCar();
            makeTbCustomer();
            makeTbSeller();
            makeTbDeal();
        }

        public void dropAllTB()
        {
            dropTable("TRADE_T", "TRADE_T_SEQ");
            dropTable("CUSTOMER_T", "CUSTOMER_T_SEQ");
            dropTable("CAR_T", "CAR_T_SEQ");
            dropTable("SELLER_T", "SELLER_T_SEQ");
            
        }
        public void dropTable(string tb,string seq)
        {
            try
            {
                string query = "drop table C##SCOTT."+ tb;
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "drop sequence C##SCOTT." + seq;
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine(tb+seq+"테이블, 시퀀스 삭제 성공");
            }
            catch (OracleException e)
            {

                errorMsg(DROP_TB_ERR, e);
            }

        }


        // 0329추가
        public void insertCar()
        {
            try
            {
                String sql = "insert into CAR_T values (car_t_SEQ.nextval,'2021년','그랜저',40000000,'은색')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                Console.WriteLine("car 데이터 추가 성공");
            }
            catch (OracleException e)
            {
                errorMsg("insertCar()", e);
            }
        }
        public void insertCar(Car car)
        {
            try
            {
               
                string sql = string.Format("insert into CAR_T values " +
                    "(car_t_SEQ.nextval,'{0}','{1}','{2}','{3}')"
                    , car.Year, car.Model,  car.Money, car.Color);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                Console.WriteLine("car 데이터 추가 성공");
            }
            catch (OracleException e)
            {
                errorMsg("insertCar()", e);
            }
        }

        public void insertSeller()
        {
            try
            {
                String sql = "insert into SELLER_T values (seller_t_SEQ.nextval,'김철수','010-1111-1111','kim@hyndai.com','동대구영업소','대리')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                Console.WriteLine("seller 데이터 추가 성공");
            }
            catch (OracleException e)
            {
                errorMsg("insertDealer()", e);
            }
        }

        public void insertSeller(Seller seller)
        {
            
            try
            {
            
                string sql = string.Format("insert into SELLER_T values " +
                    "(seller_t_SEQ.nextval,'{0}','{1}','{2}','{3}','{4}')"
                    , seller.Name, seller.Tel, seller.Email, seller.Agent, seller.Position);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                Console.WriteLine("seller 데이터 추가 성공");
            }
            catch (OracleException e)
            {
                errorMsg("insertDealer()", e);
            }
        }


        public void insertCustomer(Customer cust)
        {
            
            try
            {
                string sql = string.Format("insert into CUSTOMER_T values " +
                    "(customer_t_SEQ.nextval,'{0}','{1}','{2}','{3}')"
                    , cust.Name, cust.Addr, cust.Tel, cust.Email);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                Console.WriteLine("customer 데이터 추가 성공");
            }
            catch (OracleException e)
            {
                errorMsg("insertCustomer()", e);
            }
        }

        public void insertCustomer()
        {
            try
            {
                String sql = "insert into CUSTOMER_T values (customer_t_SEQ.nextval,'김순자','대구 동구 신천2동','010-9999-9999','kims5@naver.com')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                Console.WriteLine("customer 데이터 추가 성공");
            }
            catch (OracleException e)
            {
                errorMsg("insertCustomer()", e);
            }
        }

        public void insertDeal()
        {
            try
            {
                /* string sql = "insert into TRADE_T values (trade_t_SEQ.nextval, " +
                           " (select s.sellNum from seller_t s, customer_t cu where cu.ctmNum = s.sellNum), " +
                           " (select cu.ctmNum from customer_t cu, car_t ca where ca.carNum = cu.ctmNum), " +
                           " (select ca.carNum from car_t ca, seller_t s where s.sellNum = ca.carNum), " +
                           " sysdate) ";*/

                string sql = "insert into TRADE_T (trdNum,ctmNum,carNum,sellNum, trdDate) " +
                         "(select trade_t_SEQ.nextval,  cu.ctmNum, ca.carNum,s.sellNum, sysdate " +
                         "from seller_t s, customer_t cu, car_t ca " +
                         "where s.sellNum=cu.ctmNum and cu.ctmNum=ca.carNum)";


                /*string sql = "insert into TRADE_T (trdNum,ctmNum,carNum,sellNum, trdDate) " +
                         "(select trade_t_SEQ.nextval,  cu.ctmNum, ca.carNum, s.sellNum, sysdate " +
                         "from seller_t s natural join customer_t cu " +
                         "natural join car_t ca " +
                         "where cu.ctmName='김순자' and ca.model='그랜져' " +
                         "and s.sellName='김철수')";*/
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                Console.WriteLine("trade 데이터 추가 성공");
            }
            catch (OracleException e)
            {
                errorMsg("insertCustomer()", e);
            }
        }

        public void insertDeal(Deal deal)
        {
            try
            {


                string sql = string.Format("insert into TRADE_T " +
                         "(trdNum,ctmNum,carNum,sellNum, trdDate) " +
                         "(select trade_t_SEQ.nextval,  " +
                         "cu.ctmNum, ca.carNum, s.sellNum, sysdate " +
                         "from seller_t s natural join customer_t cu " +
                         "natural join car_t ca " +
                         "where cu.ctmName='{0}' and ca.model='{1}' " +
                         "and s.sellName='{2}')",
                         deal.Customer.Name,deal.Car.Model,deal.Seller.Name);


                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                Console.WriteLine("trade 데이터 추가 성공");
            }
            catch (OracleException e)
            {
                errorMsg("insertCustomer()", e);
            }
        }


        public void insertDeal(Customer cust,Car car,Seller seller)
        {
            try
            {


                string sql = string.Format("INSERT into  TRADE_T VALUES "+
                    "(trade_t_SEQ.nextval, " +
                    " (select ctmNum from customer_t where ctmName = '{0}' " +
                    "and ctmTel = '{1}'), " +
                    "(SELECT carNum from car_t where model = '{2}' " +
                    "and Money = {3}), " +
                    "(SELECT sellNum from seller_t where sellName = '{4}' " +
                    "and sellTel = '{5}'), sysdate)",
             cust.Name, cust.Tel, car.Model, car.Money, seller.Name, seller.Tel);


                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                Console.WriteLine("trade 데이터 추가 성공");
            }
            catch (OracleException e)
            {
                errorMsg("insertCustomer()", e);
            }
        }

        public OracleDataReader selectDeal2()
        {
            OracleDataReader rd = null;

            try
            {

                int count = 1;
                string query = "select cu.ctmname,ca.model," +
                    "ca.money,se.sellname,d.trddate " +
                    "from trade_t d, car_t ca, customer_t cu, seller_t se " +
                    " where d.carnum = ca.carnum and d.ctmnum = cu.ctmnum " +
                    "and d.sellnum = se.sellnum";

                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
              
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("번호: " + count);
                        Console.WriteLine("고객명: " + reader["ctmname"]);
                        Console.WriteLine("모델: " + reader["model"]);
                        string price = reader["money"].ToString();
                        double dPrice = Convert.ToDouble(price);
                        NumberFormatInfo numformat =
                            new CultureInfo("ko-KR", false).NumberFormat;
                        price = dPrice.ToString("c", numformat);

                        Console.WriteLine("가격: " + price);
                        Console.WriteLine("판매자: " + reader["sellname"]);
                        Console.WriteLine("구매날짜: " + reader["trddate"]);
                        Console.WriteLine("---------------------------");
                        count++;

                    }
                    
                }
                
                else
                {
                    Console.WriteLine("데이터가 존재하지 않습니다.");
                }
                


            }
            catch (OracleException e)
            {
                errorMsg("selectDeal()", e);
                return null;
            }
            
            return rd=cmd.ExecuteReader();

        }
        public List<DealResult> selectDeal()
        {
            List<DealResult> dealResultList = new List<DealResult>();

            try
            {

                int count = 1;
                string query = "select cu.ctmname,ca.model," +
                    "ca.money,se.sellname,d.trddate " +
                    "from trade_t d, car_t ca, customer_t cu, seller_t se " +
                    " where d.carnum = ca.carnum and d.ctmnum = cu.ctmnum " +
                    "and d.sellnum = se.sellnum";

                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("번호: " + count);
                        Console.WriteLine("고객명: " + reader["ctmname"]);
                        Console.WriteLine("모델: " + reader["model"]);
                        string price = reader["money"].ToString();
                        double dPrice = Convert.ToDouble(price);
                        NumberFormatInfo numformat =
                            new CultureInfo("ko-KR", false).NumberFormat;
                        price = dPrice.ToString("c", numformat);

                        Console.WriteLine("가격: " + price);
                        Console.WriteLine("판매자: " + reader["sellname"]);
                        Console.WriteLine("구매날짜: " + reader["trddate"]);
                        Console.WriteLine("---------------------------");
                        DealResult dResult = new DealResult(count,
                            reader["ctmname"].ToString(),
                            reader["model"].ToString(),
                            price,
                            reader["sellname"].ToString(),
                            reader["trddate"].ToString());
                        dealResultList.Add(dResult);
                        count++;

                    }

                }
                else
                {
                    Console.WriteLine("데이터가 존재하지 않습니다.");
                }



            }
            catch (OracleException e)
            {
                errorMsg("selectDeal()", e);
               
            }
            return dealResultList;

        }
    }
}
