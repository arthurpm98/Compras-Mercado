namespace ComprasMercado
{
    internal class Uteis
    {
        public string csql = "";
        public bool bAux = false;
        private string query;

        public string MontaQuery(string campos, string tabela, string criterio = "", string ordem = "")
        {
            query = "SELECT " + campos + " FROM " + tabela;
            if (criterio != "") { query = query + " WHERE " + criterio; }
            if (ordem != "") { query = query + " ORDER BY " + ordem; }
            return query;
        }

        public string MontaInsert(string tabela, string values, string campos = "")
        {
            query = "INSERT INTO " + tabela;
            if (campos != "") { query = query + " ( " + campos + " ) "; }
            query = query + " VALUES(" + values + ")";
            return query;
        }
    }
}
