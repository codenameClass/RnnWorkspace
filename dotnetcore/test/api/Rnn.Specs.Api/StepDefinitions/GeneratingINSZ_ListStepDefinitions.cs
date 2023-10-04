using Rnn.Client;
using Rnn.Contracts;
using Rnn.Specs.Api.Support;
using System;
using System.Globalization;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow.CommonModels;

namespace Rnn.Specs.Api.StepDefinitions
{
    [Binding]
    public class GeneratingINSZ_ListStepDefinitions
    {
        private readonly ApiContext _apiContext;
        private readonly InszClient _inszClient;

        public GeneratingINSZ_ListStepDefinitions(ApiContext apiContext)
        {
            _inszClient = new InszClient();
            _apiContext = apiContext;
        }

        [When(@"the users asks for an INSZ generation")]
        public async Task WhenTheUsersAsksForAnINSZGeneration()
        {
            var response = await _inszClient.GetAllInsz(null);

            _apiContext.Results.Add(response);
        }

        [Then(@"the INSZ list should contain (.*) randomly generated INSZ-number\(s\)")]
        [Then(@"the INSZ list should contain (.*) randomly generated INSZ-numbers")]
        [Then(@"the INSZ list should contain (.*) randomly generated INSZ-number")]
        public void ThenTheINSZListShouldContainRandomlyGeneratedINSZ_NumberS(int amount)
        {
            ((GetAllInszResponse?)_apiContext.CurrentResult.Data)?.Inszs.Should().HaveCount(amount);
        }

        [When(@"the users asks for an INSZ generation as")]
        public async Task WhenTheUsersAsksForAnINSZGenerationAs(Table parametersTable)
        {
            var inszQueryParameterList = parametersTable.Rows.AsEnumerable().Select(row =>
            {
                var newQueryParameters = new GetAllInszQueryParameters();

                if (row.ContainsKey("date")) newQueryParameters.Date = row["date"];
                if (row.ContainsKey("amount")) newQueryParameters.Amount = row["amount"];
                if (row.ContainsKey("info")) newQueryParameters.Info = row["info"];
                if (row.ContainsKey("adult")) newQueryParameters.Adult = row["adult"];

                return newQueryParameters;
            }).ToList();

            foreach (var inszQueryParameter in inszQueryParameterList)
            {
                try
                {
                    var response = await _inszClient.GetAllInsz(inszQueryParameter);

                    _apiContext.Results.Add(response);

                }
                catch (HttpRequestException ex)
                {
                    throw new Exception($"Error while requesting INSZ generation: {ex.Message}");
                }
            }
            
        }

        [Then(@"the ask attempt should fail with error ""([^""]*)""")]
        public void ThenTheAskAttemptShouldFailWithError(string errorMessage)
        {
            _apiContext.CurrentResult.Error.Should().NotBeNull();
            _apiContext.CurrentResult.Error?.Message.Should().Be(errorMessage);
        }

        [Then(@"the INSZ list should contain (.*) randomly generated INSZ-number\(s\) with associated age and sex")]
        [Then(@"the INSZ list should contain (.*) randomly generated INSZ-numbers with associated age and sex")]
        [Then(@"the INSZ list should contain (.*) randomly generated INSZ-number with associated age and sex")]
        public void ThenTheINSZListShouldContainRandomlyGeneratedINSZ_NumberSWithAssociatedAgeAndSex(int amount)
        {
            var contextInszsResult = ((GetAllInszResponse?)_apiContext.CurrentResult.Data)?.Inszs;
            contextInszsResult.Should().HaveCount(amount);
            contextInszsResult.Should().ContainMatch("insz: *, age: *, sex: *");
        }

        [Then(@"the INSZ-number\(s\) should be that of an adult")]
        [Then(@"the INSZ-numbers should be that of an adult")]
        [Then(@"the INSZ-number should be that of an adult")]
        public void ThenTheINSZ_NumberSShouldBeThatOfAnAdult()
        {
            var contextInszsResult = ((GetAllInszResponse?)_apiContext.CurrentResult.Data)?.Inszs;

            var hasInfo = (contextInszsResult?.Contains("insz:") ?? false) 
                && contextInszsResult.Contains("age:") 
                && contextInszsResult.Contains("sex:");

            if (contextInszsResult != null)
            {
                foreach (var result in contextInszsResult)
                {
                    string insz = result;

                    if (hasInfo)
                    {
                        var information = GetInformationOutOfInfo(result);
                        information.Age.Should().BeGreaterOrEqualTo(18);

                        insz = information.Insz;
                    }

                    DateTime birthdate = GetBirthdateFromInsz(insz);
                    int age = CalculateAge(birthdate, DateTime.Now);

                    age.Should().BeGreaterOrEqualTo(18);
                }
            }

        }

        private (string Insz, int Age, string Sex) GetInformationOutOfInfo(string result)
        {
            // Split the result by comma and space to extract age and sex
            var parts = result.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            // Initialize variables to store age and sex
            string insz = "";
            int age = 0;
            string sex = "";

            foreach (var part in parts)
            {
                if (part.StartsWith("insz:"))
                {
                    // Extract sex from the "sex:" part
                    insz = part.Replace("insz:", "").Trim();
                }
                else if (part.StartsWith("age:"))
                {
                    // Extract age from the "age:" part
                    int.TryParse(part.Replace("age:", "").Trim(), out age);
                }
                else if (part.StartsWith("sex:"))
                {
                    // Extract sex from the "sex:" part
                    sex = part.Replace("sex:", "").Trim();
                }
            }

            return (insz, age, sex);
        }
        private DateTime GetBirthdateFromInsz(string inszNumber)
        {
            // The first 6 digits represent the birthdate in YYMMDD format
            string datePart = inszNumber.Substring(0, 6);

            // Assuming the datePart is in YYMMDD format, we append "19" or "20" to make it a valid year
            int yearPart = int.Parse(datePart.Substring(0, 2));
            if (yearPart >= 0 && yearPart <= 12)
            {
                datePart = "20" + datePart;
            }
            else
            {
                datePart = "19" + datePart;
            }

            // Parse the date
            DateTime birthdate = DateTime.ParseExact(datePart, "yyyyMMdd", CultureInfo.InvariantCulture);

            return birthdate;
        }
        private int CalculateAge(DateTime birthdate, DateTime currentDate)
        {
            int age = currentDate.Year - birthdate.Year;

            // Adjust age if the birthday hasn't occurred yet this year
            if (birthdate.Date > currentDate.Date.AddYears(-age))
            {
                age--;
            }

            return age;
        }

        [Then(@"the INSZ-number\(s\) should start with (.*)\.")]
        [Then(@"the INSZ-numbers should start with (.*)\.")]
        [Then(@"the INSZ-number should start with (.*)\.")]
        public void ThenTheINSZ_NumberSShouldStartWith_(string firstSixDigits)
        {
            var contextInszsResult = ((GetAllInszResponse?)_apiContext.CurrentResult.Data)?.Inszs;

            if (contextInszsResult != null)
            {
                foreach(var result in contextInszsResult)
                {
                    result.Should().StartWith(firstSixDigits);
                }
            }

        }
    }
}
