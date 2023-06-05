using AVEVA_code_test.Models;
using Logger;
using Newtonsoft.Json;
using RestSharp;

namespace UserInterface.UtilityFunctions
{
    /// <summary>
    /// The class that handels all API request for the UI
    /// </summary>
    public class ApiHandler
    {
        /// <summary>
        /// Makes a request to the WebAPI to create an employee
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="currentlyEmployed"></param>
        /// <param name="client">A RestClient that already has a baseurl specified</param>
        /// <returns>returns a string with the result of the creation e.g employee created</returns>
        public static string CreateEmployee(string firstName, string lastName, string email, DateTime dateOfBirth, bool currentlyEmployed, RestClient client)
        {
            try
            {
                string message = "";
                EmployeeDTO employee = new EmployeeDTO(firstName, lastName, email, dateOfBirth, currentlyEmployed);
                RestRequest employeeUpdateRequest = new RestRequest($"CreateEmployee", Method.Post);
                employeeUpdateRequest.AddBody(employee);

                Task<RestResponse> employeeUpdateResponse = client.PostAsync(employeeUpdateRequest);
                if (employeeUpdateResponse.Result.Content != null)
                {
                    RestResponse result = employeeUpdateResponse.Result;
                    message = JsonConvert.DeserializeObject<string>(result.Content);
                }

                return message;
            }
            catch (Exception e)
            {
                SimpleLogger.Log(e);
                throw;
            }
         
        }
        /// <summary>
        /// Makes a update request to the WebAPI.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="currentlyEmployed"></param>
        /// <param name="Client">A RestClient that already has a baseurl specified</param>
        /// <returns></returns>
        public static string UpdateEmployee(int id, string firstName, string lastName, string email, DateTime dateOfBirth, bool currentlyEmployed, RestClient Client)
        {
            try
            {
                string message = "";
                Employee employee = new Employee(id, firstName, lastName, email, dateOfBirth, currentlyEmployed);
                RestRequest employeeUpdateRequest = new RestRequest($"UpdateEmployee", Method.Put);
                employeeUpdateRequest.AddBody(employee);

                Task<RestResponse> employeeUpdateResponse = Client.PutAsync(employeeUpdateRequest);
                if (employeeUpdateResponse.Result.Content != null)
                {
                    RestResponse result = employeeUpdateResponse.Result;
                    message = JsonConvert.DeserializeObject<string>(result.Content);
                }

                return message;
            }
            catch (Exception e)
            {
                SimpleLogger.Log(e);
                throw;
            }
            
        }
        /// <summary>
        /// Makes a get request to the WebAPI.
        /// if no field or value is specified it will request a list of all employees
        /// else it will request a filtered list
        /// </summary>
        /// <param name="field"></param>
        /// <param name="value"></param>
        /// <param name="client">A RestClient that already has a baseurl specified</param>
        /// <returns></returns>
        public static List<Employee> GetEmployees(string field, string value, RestClient client)
        {

            try
            {
                if (string.IsNullOrEmpty(field) || string.IsNullOrWhiteSpace(field) || string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {

                    RestRequest employeeListRequest = new RestRequest($"GetEmployeeList", Method.Get);

                    Task<RestResponse> employeeListResponse = client.GetAsync(employeeListRequest);
                    if (employeeListResponse.Result.Content != null)
                    {
                        return JsonConvert.DeserializeObject<List<Employee>>(employeeListResponse.Result.Content);
                    }
                }

                RestRequest request = new RestRequest($"GetFilteredEmployeeList?field={field}&value={value}", Method.Get);

                Task<RestResponse> response = client.GetAsync(request);
                if (response.Result.Content != null)
                {
                    return JsonConvert.DeserializeObject<List<Employee>>(response.Result.Content);
                }

                return new List<Employee>();
            }
            catch (Exception e)
            {
                SimpleLogger.Log(e);
                throw;
            }

        }

    }

}
