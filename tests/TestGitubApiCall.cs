using System;
using Xunit;
using ApiCall;


namespace tests
{
    public class TestGithubApiCall
    {
 
        [Fact]
        public void TestSuccessfulCall()
        {
            GithubApiCall apiCall = new GithubApiCall();
            string response = apiCall.GetRepos("Zahra-T");
            bool containsBitly = response.Contains("bitly");
            Assert.True(containsBitly);
        }

        [Fact]
        public void TestNotFoundCall(){
            GithubApiCall apiCAll = new GithubApiCall();
            string response = apiCAll.GetRepos("sdfskjg");
            string expectedResponse = "{\"message\":\"Not Found\",\"documentation_url\":\"https://developer.github.com/v3/repos/#list-user-repositories\"}";
            Assert.Equal(response, expectedResponse);
        }
    }
}
