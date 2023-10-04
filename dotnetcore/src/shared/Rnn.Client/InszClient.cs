using Rnn.Contracts;
using System;
using System.Net.Http.Json;
using System.Web;

namespace Rnn.Client
{
    public class InszClient : IDisposable
    {
        private readonly HttpClient _httpClient;
        private readonly Uri _baseUri;

        public InszClient()
        {
            _baseUri = new Uri(@"https://ny652h2ixk.execute-api.eu-west-1.amazonaws.com/Prod//insz");

            _httpClient = new HttpClient()
            {
                BaseAddress = _baseUri
            };
        }

        public void Dispose()
        {
            _httpClient.Dispose();
        }


        private string? GenerateGetAllInszQueryParams(UriBuilder uriBuilder, GetAllInszQueryParameters parameters)
        {
            var queryParams = HttpUtility.ParseQueryString(uriBuilder.Query);

            if (!string.IsNullOrEmpty(parameters.Date))
            {
                queryParams["date"] = parameters.Date;
            }

            if (!string.IsNullOrEmpty(parameters.Amount))
            {
                queryParams["amount"] = parameters.Amount;
            }

            if (!string.IsNullOrEmpty(parameters.Info))
            {
                queryParams["info"] = parameters.Info;
            }

            if (!string.IsNullOrEmpty(parameters.Adult))
            {
                queryParams["adult"] = parameters.Adult;
            }

            return queryParams?.ToString();
        }
        public async Task<(GetAllInszResponse? Data, ErrorResponse? Error)> GetAllInsz(GetAllInszQueryParameters? parameters)
        {
            var uriBuilder = new UriBuilder(_baseUri);

            if (parameters != null)
            {
                uriBuilder.Query = GenerateGetAllInszQueryParams(uriBuilder, parameters);
            }

            Uri getAllInszQueryUrl = uriBuilder.Uri;

            var response = await _httpClient.GetAsync(getAllInszQueryUrl);

            if(!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadFromJsonAsync<ErrorResponse>();

                return error != null 
                    ? (null, error)
                    : throw new Exception("An unhandled InszClient error occurred while reading the error.");
            }

            var data = await response.Content.ReadFromJsonAsync<GetAllInszResponse>();

            return data != null
                ? (data, null)
                : throw new Exception("An unhandled InszClient error occurred while reading the data."); ;
        }

    }
}