using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySqlConnector;

namespace CST_Project_1
{
    internal class MySql : ISql
    {

            private readonly MySqlConnection _con;
            private readonly string _table;
            private readonly string _tableCat;
            private StringBuilder _log;

            public string Log => _log.ToString();

            public MySql(string table, string tableCategory) {
                string connectionString =
                    $@"Server={Program.Configuration.Server};Port={Program.Configuration.Port};Uid={Program.Configuration.Username};Pwd={Program.Configuration.Password};Database={Program.Configuration.Database}";
                _log = new StringBuilder();
                _log.AppendLine($"{connectionString}");
                _con = new MySqlConnection(connectionString);
                _table = table;
                _tableCat = tableCategory;
            }

            public async Task CreateDatabaseAsync() {
                await CreateDatabaseAsync(_table, _tableCat);
            }

            private async Task CreateDatabaseAsync(string table, string tableCategory) {

                string cmd = $@"create table if not exists {tableCategory} (
                                    id int primary key,
                                    name text
                                );

                                create table if not exists {table} (
                                    id int primary key,
                                    name text,
                                    brand text,
                                    quantity bigint,
                                    price decimal,
                                    category int references {tableCategory}(id)
                                );";

                await Connect();
                await Execute(cmd);
            }
        
            private async Task<int> Execute(string query)
            {
                _log.AppendLine($"Execute: {query}");
                var cmd = new MySqlCommand(query, _con);
                return await cmd.ExecuteNonQueryAsync();
            }

            /// <summary>
            /// Creates a new reader of the data specified by the <see cref="query"/>
            /// </summary>
            /// <param name="query">The MYSQL Query to send to the server</param>
            /// <returns>A new <see cref="DbDataReader"/></returns>
            private async Task<MySqlDataReader> ExecuteReader(string query)
            {
                var cmd = new MySqlCommand(query, _con);
                return await cmd.ExecuteReaderAsync();
            }

            #region Implementation of ISql

            /// <inheritdoc />
            public async Task InsertInto(string table, Dictionary<string, dynamic> data) {
                string commandStr =
                    $"INSERT INTO {table} ({data.Keys.Aggregate((x, y) => $"{x}, {y}")}) VALUES ({data.Values.Aggregate((x, y) => $"{x}, {y}")})";
                //System.Windows.Forms.MessageBox.Show(commandStr);
                await
                    Execute(commandStr);
            }

            public async Task InsertInto(Dictionary<string, dynamic> data) => await InsertInto(_table, data);


            /// <inheritdoc />
            public async Task Update(string table, Dictionary<string, object> newData, string queryColumn, dynamic queryValue)
            {
                var sb = new StringBuilder();
                foreach (KeyValuePair<string, dynamic> k in newData)
                {

                    sb.Append(long.TryParse(Convert.ToString(k.Value), out long v)
                                  ? $"{k.Key}={v},"
                                  : $"{k.Key}={k.Value},");
                }
                string query =
                    $"UPDATE {table} set {sb.ToString().TrimEnd(",".ToCharArray())} WHERE {queryColumn}={queryValue}";
                await Execute(query);
            }
            public async Task Update(Dictionary<string, object> newData, string queryColumn, dynamic queryValue) => await Update(_table, newData, queryColumn, queryValue);

            /// <inheritdoc />
            public async Task Delete(string table, int index)
            {
                await Delete(table, $"INDEX = `{index}`");
            }

            public async Task Delete(int index) => await Delete(_table, index);

            /// <inheritdoc />
            public async Task Delete(string table, string query) {
                string commandStr = $"DELETE FROM `{table}` WHERE {query};";
                await Execute(commandStr);
            }

            public async Task Delete(string queryColumn, dynamic queryValue) => await Delete(table: _table, $"`{queryColumn}`={queryValue}");

            public async Task Delete(string query) => await Delete(query);


            public async Task<bool> Exists(string table, string column, dynamic entry)
            {
                bool ret = false;
                MySqlDataReader reader = await ExecuteReader($"SELECT * FROM `{table}` WHERE `{column}`='{entry}'");
                while (await reader.ReadAsync())
                {
                    dynamic ts = await reader.GetFieldValueAsync<dynamic>(0);
                    ret = ts != null;
                    break;
                }

                reader.Close();
                return ret;
            }

            public async Task<bool> Exists(string column, dynamic entry) => await Exists(_table, column, entry);

            /// <inheritdoc />
            public async Task Connect()
            {
                await _con.OpenAsync();
            }

            /// <inheritdoc />
            public async Task Disconnect()
            {
                await _con.CloseAsync();
            }

            #endregion

            public async Task< List< object > > GetEntries(string table) {
                return await GetEntry< dynamic >(table: table, "*");
            }

            public async Task<List<T>> GetEntry<T>(string table, string column, string queryColumn = "",
                                                           dynamic queryValue = default) {
                if (_con.State != ConnectionState.Open)
                    throw new Exception("Database not connected!");

                string query = queryColumn.IsEmpty()
                    ? $"SELECT {column} from `{table}`"
                    : $"SELECT {column} from `{table}` where `{queryColumn}`='{queryValue}'";

                MySqlDataReader reader = await ExecuteReader(query);

                List<T> lst = new List<T>();
                while (await reader.ReadAsync())
                {
                    T[] values = new T[reader.FieldCount];
                    object[] obj = new object[reader.FieldCount];
                    reader.GetValues(obj);
                    foreach (object o in obj) {
                        lst.Add((T)Convert.ChangeType(o, typeof(T)));
                    }
                }
                reader.Close();
                return lst;
            }
            public async Task<List<T>> GetEntry<T>(string column, string queryColumn = "",
                                                           dynamic queryValue = default) => await GetEntry<T>(_table, column, queryColumn, queryValue);
    }
}

