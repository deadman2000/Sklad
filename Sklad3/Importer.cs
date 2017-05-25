using FirebirdSql.Data.Firebird;
using Sklad3.Objects;
using System;
using System.Collections.Generic;
using System.Data;

namespace Sklad3
{
    static class Importer
    {
        private static string connectionString;
        // http://www.firebirdsql.org/en/odbc-driver/

        public static void Import(string fileName)
        {
            FbConnectionStringBuilder csBuilder = new FbConnectionStringBuilder();
            csBuilder.Dialect = 3;
            csBuilder.DataSource = "localhost";
            csBuilder.UserID = "SYSDBA";
            csBuilder.Password = "masterkey";
            csBuilder.Database = fileName;
            connectionString = csBuilder.ToString();

            DbSklad.CreateNewDataBase();

            Console.WriteLine("Months");
            Month month;
            DateTime monthBg, monthEn;
            {
                var tbl = ExecuteTable("SELECT * FROM DATES");
                var row = tbl.Rows[0];
                monthBg = (DateTime)row["BG"];
                monthEn = monthBg.AddMonths(1);
                month = DbSklad.AddMonth(monthBg);
                DbSklad.CurrentMonth = month;
            }

            Console.WriteLine("Edism");
            var edIsmDict = new Dictionary<int, EdIsm>();
            {
                var tbl = ExecuteTable("SELECT * FROM ED_ISM ORDER BY ID");
                Console.WriteLine("  Count: " + tbl.Rows.Count);
                foreach (DataRow row in tbl.Rows)
                {
                    var id = (int)row["ID"];
                    var name = (string)row["NAME"];
                    var it = DbSklad.AddEdIsm(name);
                    edIsmDict.Add(id, it);
                }
            }

            Console.WriteLine("Tovars");
            var tovarDict = new Dictionary<int, Tovar>();
            {
                FbCommand cmd = new FbCommand("select * from tovar where (id in (select idtov from sklpr where datepr between @b and @e)) or (id in (select idtov from sklrs where daters between @b and @e)) or (id in (select idtov from sklnm where datenm between @b and @e)) order by id");
                cmd.Parameters.Add("@b", monthBg);
                cmd.Parameters.Add("@e", monthEn);
                var tbl = ExecuteTable(cmd);
                Console.WriteLine("  Count: " + tbl.Rows.Count);
                int count = 0;
                foreach (DataRow row in tbl.Rows)
                {
                    var id = (int)row["ID"];
                    var name = (string)row["NAME"];
                    var edism = (int)row["IDEI"];
                    var price = (double)(decimal)row["PRISE"];
                    var invn = (string)row["INVN"];
                    var nsch = (string)row["NSCH"];

                    var innerEdIsm = edIsmDict[edism];

                    var tov = DbSklad.AddTovar(name, innerEdIsm, price, invn, nsch);
                    tovarDict.Add(id, tov);
                    count++;
                    if (count % 100 == 0)
                        Console.WriteLine("Tovar: {0}/{1}", count, tbl.Rows.Count);
                }
            }


            Console.WriteLine("SchFact");
            var sfDict = new Dictionary<int, SFact>();
            {
                FbCommand cmd = new FbCommand("select * from sf where id in (select idsf from sklpr where datepr between @b and @e) order by id");
                cmd.Parameters.Add("@b", monthBg);
                cmd.Parameters.Add("@e", monthEn);
                var tbl = ExecuteTable(cmd);
                Console.WriteLine("  Count: " + tbl.Rows.Count);
                foreach (DataRow row in tbl.Rows)
                {
                    var id = (int)row["ID"];
                    var name = (string)row["NUM"];
                    var predp = (string)row["PREDP"];
                    var date = (DateTime)row["DATESF"];

                    var p = DbSklad.GetPredp(predp);

                    SFact sf = DbSklad.AddSf(name, p, date);
                    sfDict.Add(id, sf);
                }
            }
            Console.WriteLine("SklPr");
            {
                FbCommand cmd = new FbCommand("SELECT * FROM SKLPR where datepr between @b and @e ORDER BY ID");
                cmd.Parameters.Add("@b", monthBg);
                cmd.Parameters.Add("@e", monthEn);
                var tbl = ExecuteTable(cmd);
                Console.WriteLine("  Count: " + tbl.Rows.Count);
                foreach (DataRow row in tbl.Rows)
                {
                    var id = (int)row["ID"];
                    var tov = tovarDict[(int)row["IDTOV"]];
                    var count = (double)(decimal)row["KOL"];
                    var sf = sfDict[(int)row["IDSF"]];
                    var date = (DateTime)row["DATEPR"];
                    var typeDoc = (string)row["TYPEDOC"];

                    DbSklad.AddPrihod(month, tov, count, date, typeDoc, sf);
                }
            }


            Console.WriteLine("RasDoc");
            Dictionary<int, Ras> _rasDocId = new Dictionary<int, Ras>();
            {
                FbCommand cmd = new FbCommand("select * from ras where id in (select idrs from sklrs where daters between @b and @e) order by id");
                cmd.Parameters.Add("@b", monthBg);
                cmd.Parameters.Add("@e", monthEn);
                var tbl = ExecuteTable(cmd);
                Console.WriteLine("  Count: " + tbl.Rows.Count);
                foreach (DataRow row in tbl.Rows)
                {
                    var id = (int)row["ID"];
                    var dolj = DbSklad.GetDolj((string)row["FIO"]);
                    var podr = DbSklad.GetPodrazd((string)row["PODR"]);
                    int? ntreb = row["NTREB"] is DBNull ? (int?)null : (int)row["NTREB"];
                    var date = (DateTime)row["DATESOST"];

                    var rasDoc = DbSklad.GetRasDoc(dolj, podr, ntreb, date);
                    _rasDocId.Add(id, rasDoc);
                }
            }
            Console.WriteLine("SklRas");
            {
                FbCommand cmd = new FbCommand("SELECT * FROM SKLRS where daters between @b and @e ORDER BY ID");
                cmd.Parameters.Add("@b", monthBg);
                cmd.Parameters.Add("@e", monthEn);
                var tbl = ExecuteTable(cmd);
                Console.WriteLine("  Count: " + tbl.Rows.Count);
                foreach (DataRow row in tbl.Rows)
                {
                    var id = (int)row["ID"];
                    var tov = tovarDict[(int)row["IDTOV"]];
                    var count = (double)(decimal)row["KOL"];
                    var idRS = (int)row["IDRS"];
                    var date = (DateTime)row["DATERS"];

                    DbSklad.AddRashod(month, tov, count, date, _rasDocId[idRS]); 
                }
            }

            Console.WriteLine("SklNm");
            {
                FbCommand cmd = new FbCommand("SELECT * FROM SKLNM where datenm between @b and @e ORDER BY ID");
                cmd.Parameters.Add("@b", monthBg);
                cmd.Parameters.Add("@e", monthEn);
                var tbl = ExecuteTable(cmd);
                Console.WriteLine("  Count: " + tbl.Rows.Count);
                foreach (DataRow row in tbl.Rows)
                {
                    var id = (int)row["ID"];
                    var tov = tovarDict[(int)row["IDTOV"]];
                    var count = (double)(decimal)row["KOL"];

                    DbSklad.AddMonthBeg(month, tov, count);
                }
            }

            Console.WriteLine("Completed");
        }

        private static FbConnection CreateConnection()
        {
            return new FbConnection(connectionString);
        }

        private static DataTable ExecuteTable(string sql)
        {
            return ExecuteTable(new FbCommand(sql));
        }

        private static DataTable ExecuteTable(FbCommand command)
        {
            DataTable table;
            using (var conn = CreateConnection())
            {
                conn.Open();

                var dataAdapter = new FbDataAdapter(command);
                command.Connection = conn;
                table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
            }
            return table;
        }

    }
}
