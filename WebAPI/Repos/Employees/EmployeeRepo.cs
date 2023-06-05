using Logger;
using Microsoft.AspNetCore.Http;
using Npgsql;
using WebAPI.Models;
using WebAPI.UtilityFunctions;

namespace WebAPI.Repos.Employees
{
    /// <summary>
    /// The WebAPI uses the repository pattern to ensure decoupling between the persistence layer and the rest of the application
    /// this class is the implementation of the persistence-specific adapter which in this case is Npgsql.
    /// </summary>
    public class EmployeeRepo : IEmployeeRopo
    {
        public EmployeeRepo(IConfiguration Configuration)
        {
            _configuration = Configuration;
        }

        private IConfiguration _configuration { get; }
        /// <summary>
        /// Creates the Employee in the database
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>returns a string informing the caller of result</returns>
        public string Create(EmployeeDTO employee)
        {
            string queryExsisting = "SELECT Id FROM public.Employees where Email = @email";
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(_configuration.GetConnectionString("db")))
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(queryExsisting, connection);
                    NpgsqlParameter[] param = new NpgsqlParameter[1];
                    param[0] = new NpgsqlParameter("@email", employee.Email);
                    cmd.Parameters.Add(param[0]);
                    cmd.Connection.Open();
                    var reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                int id = reader.GetInt32(0);
                                SimpleLogger.Log("employee with the Id already exists: " + id);
                                return "Already exists";
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                SimpleLogger.Log(e);
                throw;
            }

            string Insert = "INSERT INTO public.employees(FirstName, LastName, Email, DateOfBirth, CurrentlyEmployed) VALUES( @firstname, @lastname, @email, @dateofbirth, @currentlyemployed); ";
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(_configuration.GetConnectionString("db")))
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(Insert, connection);
                    NpgsqlParameter[] param = new NpgsqlParameter[5];
                    param[0] = new NpgsqlParameter("@firstname", employee.FirstName);
                    param[1] = new NpgsqlParameter("@lastname", employee.LastName);
                    param[2] = new NpgsqlParameter("@email", employee.Email);
                    param[3] = new NpgsqlParameter("@dateofbirth", employee.DateOfBirth);
                    param[4] = new NpgsqlParameter("@currentlyemployed", employee.CurrentlyEmployed);
                    cmd.Parameters.Add(param[0]);
                    cmd.Parameters.Add(param[1]);
                    cmd.Parameters.Add(param[2]);
                    cmd.Parameters.Add(param[3]);
                    cmd.Parameters.Add(param[4]);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                }

                return "Employee created";
            }
            catch (Exception e)
            {
                SimpleLogger.Log(e);
                return "Failed to create employee";
            }
        }

        /// <summary>
        /// Gets a list of all employees
        /// </summary>
        /// <returns>returns a list of employees</returns>
        public IEnumerable<Employee> Get()
        {
            string queryString = "SELECT * FROM public.employees order by id ASC;";

            try
            {
                using (NpgsqlConnection Connection = new NpgsqlConnection(_configuration.GetConnectionString("db")))
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(queryString, Connection);

                    cmd.Connection.Open();
                    var reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                    List<Employee> employees = new List<Employee>();

                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0) && !reader.IsDBNull(1) && !reader.IsDBNull(2) && !reader.IsDBNull(3) && !reader.IsDBNull(4) && !reader.IsDBNull(5))
                        {
                            employees.Add(new Employee(id: reader.GetInt32(0), firstName: reader.GetString(1), lastName: reader.GetString(2), email: reader.GetString(3), dateOfBirth:reader.GetDateTime(4), currentlyEmployed: reader.GetBoolean(5)));
                        }
                        else
                        {
                            SimpleLogger.Log("Get request skipped employee with the Id: " + reader.GetInt32(0));
                        }
                    }

                    return employees;
                }
            }
            catch (Exception e)
            {
                SimpleLogger.Log(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of employees based on a criteria from the user
        /// </summary>
        /// <param name="column">The column in the database table </param>
        /// <param name="value">The value to filter by </param>
        /// <returns>returns a list of employees</returns>
        public IEnumerable<Employee> Get(string column, string value)
        {
            string queryString;
            column = column.Replace(" ", "");
            value = value.TrimStart();
            List<Employee> employees = new List<Employee>();
            try
            {
                dynamic convertedValue;
               
                if(SqlPreparation.VerifyType(column, value,out convertedValue))
                {
                    queryString= SqlPreparation.FindAppropriateQueryString(column);
                }
                else
                {
                    return employees;
                }

                using (NpgsqlConnection connection = new NpgsqlConnection(_configuration.GetConnectionString("db")))
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(queryString, connection);
                    NpgsqlParameter[] param = new NpgsqlParameter[1];
                    param[0] = new NpgsqlParameter("@value", convertedValue);
                    cmd.Parameters.Add(param[0]);

                    cmd.Connection.Open();
                    var reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0) && !reader.IsDBNull(1) && !reader.IsDBNull(2) && !reader.IsDBNull(3) && !reader.IsDBNull(4) && !reader.IsDBNull(5))
                        {
                            employees.Add(new Employee(id: reader.GetInt32(0), firstName: reader.GetString(1), lastName: reader.GetString(2), email: reader.GetString(3), dateOfBirth: reader.GetDateTime(4), currentlyEmployed: reader.GetBoolean(5)));
                        }
                        else
                        {
                            SimpleLogger.Log("Get-request skipped employee with the Id: " + reader.GetInt32(0));
                        }
                    }

                    return employees;
                }
            }
            catch (Exception e)
            {
                SimpleLogger.Log(e);
                
                return new List<Employee>();
            }
        }
        
        /// <summary>
        /// Updates an employee.
        /// id is used to find the specific employee to update
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>returns a string of the updating status</returns>
        public string Update(Employee employee)
        {
            string queryString = "SELECT * FROM public.employees where Id = @id";

            try 
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(_configuration.GetConnectionString("db")))
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(queryString, connection);
                    NpgsqlParameter[] param = new NpgsqlParameter[1];
                    param[0] = new NpgsqlParameter("@id", employee.Id);
                    cmd.Parameters.Add(param[0]);

                    cmd.Connection.Open();
                    var reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        Employee retrivedEmployee;
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0) && !reader.IsDBNull(1) && !reader.IsDBNull(2) && !reader.IsDBNull(3) && !reader.IsDBNull(4) && !reader.IsDBNull(5))
                            {
                                int id = reader.GetInt32(0);
                                string firstName = reader.GetString(1);
                                string lastName = reader.GetString(2);
                                string email = reader.GetString(3);
                                DateTime dateOfBirth = reader.GetDateTime(4);
                                bool currentlyEmployed = reader.GetBoolean(5);
                                retrivedEmployee = new Employee(id, firstName, lastName, email, dateOfBirth, currentlyEmployed);
                            }
                        }
                        reader.Close();
                        string update = "UPDATE public.Employees SET  FirstName=@firstname, LastName = @lastname, Email=@email, DateOfBirth= @dateofbirth, CurrentlyEmployed= @currentlyemployed WHERE Id=@Id";

                        NpgsqlCommand cmd2 = new NpgsqlCommand(update, connection);
                        NpgsqlParameter[] param2 = new NpgsqlParameter[6];
                        param2[0] = new NpgsqlParameter("@id", employee.Id);
                        param2[1] = new NpgsqlParameter("@firstname", employee.FirstName);
                        param2[2] = new NpgsqlParameter("@lastname", employee.LastName);
                        param2[3] = new NpgsqlParameter("@email", employee.Email);
                        param2[4] = new NpgsqlParameter("@dateofbirth", employee.DateOfBirth);
                        param2[5] = new NpgsqlParameter("@currentlyemployed", employee.CurrentlyEmployed);
                        cmd2.Parameters.Add(param2[0]);
                        cmd2.Parameters.Add(param2[1]);
                        cmd2.Parameters.Add(param2[2]);
                        cmd2.Parameters.Add(param2[3]);
                        cmd2.Parameters.Add(param2[4]);
                        cmd2.Parameters.Add(param2[5]);
                        cmd2.ExecuteNonQuery();

                        return "Employee updated";
                    }
                    else
                    {
                        return "Employee not found";
                    }
                }
            }
            catch (Exception e)
            {
                SimpleLogger.Log(e);
                throw;
            }
        }
    }
}
